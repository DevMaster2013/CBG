#include <SFGUI/SFGUI.hpp>
#include <SFGUI/Widgets.hpp>
#include <imgui.h>
#include <imgui-SFML.h>
#include <SFML/Graphics.hpp>

class IGUIHandler
{
public:
	virtual void initializeGUI() = 0;
	virtual void handleEvents(sf::Event& event) = 0;
	virtual void updateGUI(double elapsedSeconds) = 0;
	virtual void renderGUI() = 0;	
	virtual void releaseGUI() = 0;
};

enum GUIManagerType {SFGUI, ImGUI};
class SFGUIManager;
class ImGUIManager;
class IGUIManager : public IGUIHandler
{
public:
	sf::RenderWindow* renderWindow;
public:
	IGUIManager(sf::RenderWindow* renderWindow) : renderWindow(renderWindow) {}
public:
	virtual void initializeGUI() = 0;
	virtual void handleEvents(sf::Event& event) = 0;
	virtual void updateGUI(double elapsedSeconds) = 0;
	virtual void renderGUI() = 0;
	virtual void releaseGUI() = 0;
public:
	static IGUIManager* getGUIManager(sf::RenderWindow* renderWindow, GUIManagerType managerType);
};

class SFGUIManager : public IGUIManager
{
public:
	sfg::SFGUI sfgui;
	sfg::Desktop desktop;
public:
	SFGUIManager(sf::RenderWindow* renderWindow) : IGUIManager(renderWindow) {}
public:
	virtual void initializeGUI() override
	{
		renderWindow->resetGLStates();

		auto label = sfg::Label::Create("Hello world!");

		auto button = sfg::Button::Create("Greet SFGUI!");
		button->GetSignal(sfg::Widget::OnLeftClick).Connect([label] { label->SetText("Hello SFGUI, pleased to meet you!"); });

		auto box = sfg::Box::Create(sfg::Box::Orientation::VERTICAL, 5.0f);
		box->Pack(label);
		box->Pack(button, false);

		auto sfguiWindow = sfg::Window::Create();
		sfguiWindow->SetTitle("Hello world!");
		sfguiWindow->Add(box);

		desktop.Add(sfguiWindow);		
	}
	virtual void handleEvents(sf::Event& event) override
	{
		desktop.HandleEvent(event);
	}
	virtual void updateGUI(double elapsedSeconds) override
	{
		desktop.Update(elapsedSeconds);
	}
	virtual void renderGUI() override
	{
		sfgui.Display(*renderWindow);
	}
	virtual void releaseGUI() override
	{
	}
};

class ImGUIManager : public IGUIManager
{
public:
	ImGUIManager(sf::RenderWindow* renderWindow) : IGUIManager(renderWindow) {}
public:
	virtual void initializeGUI() override
	{
		ImGui::SFML::Init(*renderWindow);
	}
	virtual void handleEvents(sf::Event& event) override
	{
		ImGui::SFML::ProcessEvent(event);
	}
	virtual void updateGUI(double elapsedSeconds) override
	{
		ImGui::SFML::Update(*renderWindow, sf::seconds(elapsedSeconds));
	}
	virtual void renderGUI() override
	{
		ImGui::Begin("Hello world!");
		if (ImGui::Button("Greet SFGUI!"))
		{
			ImGui::LabelText("Hello SFGUI, pleased to meet you!", "");
		}
		else
		{
			ImGui::LabelText("Hello world!", "");
		}
		ImGui::End();
		ImGui::SFML::Render(*renderWindow);
	}
	virtual void releaseGUI() override
	{
		ImGui::SFML::Shutdown();
	}
};

IGUIManager* IGUIManager::getGUIManager(sf::RenderWindow* renderWindow, GUIManagerType managerType)
{
	switch (managerType)
	{
	case SFGUI:
		return new SFGUIManager(renderWindow);
	case ImGUI:
		return new ImGUIManager(renderWindow);
	default:
		return nullptr;
	}
}

int main(int argc, char* argv[])
{
	sf::RenderWindow window(sf::VideoMode(800, 600), "City Building Game", sf::Style::Default);
	sf::View cameraView = window.getDefaultView();
	IGUIManager* guiManager = IGUIManager::getGUIManager(&window, GUIManagerType::SFGUI);
	guiManager->initializeGUI();

	sf::Clock clock;	
	while (window.isOpen())
	{		
		window.setView(cameraView);
		sf::Time elapsed = clock.restart();
		
		sf::Event event;
		while (window.pollEvent(event))
		{
			guiManager->handleEvents(event);
			if (event.type == sf::Event::Closed)
				window.close();
			else if (event.type == sf::Event::Resized)
				cameraView.setSize((float)event.size.width, (float)event.size.height);
		}
		if (!window.isOpen()) break;

		guiManager->updateGUI(elapsed.asSeconds());

		window.clear();
		guiManager->renderGUI();
		window.display();
	}

	guiManager->releaseGUI();
	delete guiManager;

	return 0;
}
