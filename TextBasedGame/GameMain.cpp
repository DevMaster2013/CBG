#if 1
#include "..\GameCore\Game.h"
#include "..\GameLogic\CustomGameObject.h"
#include "..\GameRender\RenderableFactory.h"
#include "..\ConsoleRenderer\ConsoleRendererFactory.h"
#include <thread>

class MyGame : public Game
{
private:
	CustomGameObject* myCustomObject;

private:
	virtual void onInitializeGame() override
	{
		RenderableFactory::setRenderableFactory(new ConsoleRendererFactory());

		myCustomObject = new CustomGameObject();
		_gameObjects->addGameObject("My Custom Object", myCustomObject);
	}
};

int main(int argc, char* argv[])
{
	MyGame myGame;
	std::thread gameThread([&]() {myGame.startGame(); });	
	gameThread.join();
	
	return 0;
}
#endif

#if 0
#include <iostream>
#include <vector>
#include <string>

const double PRICE_GROW_FACTORY = 1.1;
const double PROFIT_RATIO = 0.2;

struct Building
{
public:
	std::string name;
	double price;
	double profit;
	int level;

public:
	Building(const std::string& name, double price)
		: name(name)
		, price(price)
		, profit(0.0)
		, level(0)
	{
	}

public:
	void upgrade()
	{
		level++;
		profit = PROFIT_RATIO * price;
		price = PRICE_GROW_FACTORY * price;
	}
};

class Menu
{
public:
	std::string name;
	std::vector<std::string> options;
	int chosenIndex;

public:
	Menu(const std::string& name, const std::vector<std::string>& options)
		: name(name)
		, options(options)
	{
	}

public:
	int displayMenu()
	{
		std::cout << "------" << name << "------\n";
		for (int i = 0; i < options.size(); i++)
			std::cout << i + 1 << " - " << options[i] << ".\n";
		std::cout << "\n\nEnter your choice: ";
		int option = std::cin.get();
		while (option < 1 || option > options.size())
		{
			std::cout << "Invalid Option... Press any key to continue\r";
			std::cout << "\n\nEnter your choice: ";
			option = std::cin.get();
		}

		return option;
	}
};

int main(int argc, char* argv[])
{
	std::vector<Building> gameBuildings;
	double gameBudget = 125.0;

	Menu mainMenu("Main Menu", {"Add Buildings", "Display Game State"});
	Menu buildingsMenu("Buildings Menu", { "Farm (125 L.E)", "Bakery (200 L.E)", "Iron Mine (500 L.E)" });

	int mainMenuOption = mainMenu.displayMenu();
	if (mainMenuOption == 1)
	{
		int buildingIndex = buildingsMenu.displayMenu();
		switch (buildingIndex)
		{
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		default:
			break;
		}
	}	
	else if (mainMenuOption == 2)
	{		
		for (int i = 0; i < gameBuildings.size(); i++)
			gameBudget += gameBuildings[i].profit;

		std::cout << "Current Game Budget = " << gameBudget;
	}
}
#endif