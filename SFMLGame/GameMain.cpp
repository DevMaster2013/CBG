/*
* We have a residence that have peoples, these peoples can be childs, tenagers, youngs, elders (men & womens).
* The youngs can be work force, and work in the production places.
* The population can be grown through marriage.
* The production place needs (work force, budget, tools, transporation, raw items) and it will produce products.
* The production place take a certain time, cost (budget), tools, raw items to produce one unit of the product.
* The production place then transport the products to the storehouse.
* The store house contains all the tools and the raw items needed for produciton.
* Some raw items are gathered from earth throw miners, farming, collecting, cutting, ...
* The garage contains transportation that are called to transport products.
* Each work labour has a wage that deduced from the budget of the product place.
* The profit of the product place are computed using (outcome - (wages + cost + maintainence)).
* The government collect the products and pay for them for the product places, and sell them for others.
* Each production place contain internal storehouse that contain its tools, raw items, products until selled to government.
* The garage collect profit from the service cost that are collected from the product place to deliver / take products.
*/

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

int main(int argc, char* argv[])
{
	// create the window
	sf::RenderWindow window(sf::VideoMode(800, 600), "City Building Game", sf::Style::Default);
	sf::View cameraView = window.getDefaultView();
	ImGui::SFML::Init(window);

	// create a clock to track the elapsed time
	sf::Clock clock;
	
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
			else if (event.type == sf::Event::KeyPressed)
			{
				if (event.key.code == sf::Keyboard::Escape)
				{
					window.close();
				}
			}
			else if (event.type == sf::Event::Resized)
				cameraView.setSize(event.size.width, event.size.height);			
		}

		ImGui::Begin("Dummy window");
		ImGui::End();

		// draw it
		window.clear();
		ImGui::SFML::Render(window);
		window.display();
	}

	ImGui::SFML::Shutdown();
	return 0;
}