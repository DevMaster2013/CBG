#include "Building.h"
#include "BuildingComponent.h"
#include "MaintainedComponent.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

Building::Building(const std::string & name, double budget)
	: name(name), budget(budget)
{
}

void Building::update(double elapsedSeconds)
{
	MaintainedComponent* maintanence = getComponent<MaintainedComponent>();
	bool updateAll = maintanence == nullptr || maintanence->isWorking();
	if (updateAll)
	{
		for (size_t i = 0; i < components.size(); i++)
			components[i]->update(elapsedSeconds);
		onUpdateBuilding(elapsedSeconds);
	}
	else
		maintanence->update(elapsedSeconds);
}

void Building::drawInterface()
{
	if (ImGui::Begin(name.c_str()))
	{
		for (size_t i = 0; i < components.size(); i++)
			components[i]->drawInterface();
	}
	onDrawInterfaceBuilding();
	ImGui::End();
}
