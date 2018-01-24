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
		for each (auto& component in components)
			component.second->update(elapsedSeconds);
		onUpdateBuilding(elapsedSeconds);
	}
	else
		maintanence->update(elapsedSeconds);
}

void Building::drawInterface()
{
#ifdef USE_SFGUI_INTERFACE
#else
	ImGui::SetNextWindowSize(ImVec2(1200, 700), ImGuiSetCond_FirstUseEver);
	if (ImGui::Begin(name.c_str()))
	{
		ImGui::TextUnformatted("Budget: ");
		ImGui::SameLine();
		ImGui::Text("%2.2f L.E", budget);
		for each (auto& component in components)
			component.second->drawInterface();
	}
	onDrawInterfaceBuilding();
	ImGui::End();
#endif
}
