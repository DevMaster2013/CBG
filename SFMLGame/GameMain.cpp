#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

#include "IronMine.h"
#include "CoalMine.h"

int main(int argc, char* argv[])
{
	// create the window
	sf::RenderWindow window(sf::VideoMode(800, 600), "City Building Game", sf::Style::Default);
	sf::View cameraView = window.getDefaultView();
	ImGui::SFML::Init(window);

	// create a clock to track the elapsed time
	sf::Clock clock;	
	std::vector<Building*> buildings = { new IronMine(), new CoalMine() };

	// run the main loop
	while (window.isOpen())
	{		
		window.setView(cameraView);
		sf::Time elapsed = clock.restart();
		ImGui::SFML::Update(window, elapsed);

		// handle events
		sf::Event event;
		while (window.pollEvent(event))
		{
			ImGui::SFML::ProcessEvent(event);
			if (event.type == sf::Event::Closed)
				window.close();
			else if (event.type == sf::Event::Resized)
				cameraView.setSize((float)event.size.width, (float)event.size.height);
		}

		// Interface Updating
		for (size_t i = 0; i < buildings.size(); i++)
			buildings[i]->drawInterface();

		// Update game
		for (size_t i = 0; i < buildings.size(); i++)
			buildings[i]->update(elapsed.asSeconds());

		// draw it
		window.clear();
		ImGui::SFML::Render(window);
		window.display();
	}

	ImGui::SFML::Shutdown();
	return 0;
}