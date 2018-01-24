#include "MaintainedComponent.h"
#include "Building.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

MaintainedComponent::MaintainedComponent(Building * parentBuilding, double maintainenceTime, double maintainenceCost)
	: BuildingComponent("Maintanence", parentBuilding)
	, maintainenceTime(maintainenceTime)
	, maintainenceCost(maintainenceCost)
	, runningTime(0.0)
{
}

bool MaintainedComponent::isWorking()
{
	return runningTime < maintainenceTime;
}

void MaintainedComponent::onUpdateComponent(double elapsedSeconds)
{
	runningTime += elapsedSeconds;
	if (runningTime >= maintainenceTime)
		return;
}

void MaintainedComponent::onDrawInterfaceComponent()
{
#ifdef USE_SFGUI_INTERFACE
#else
	ImGui::TextUnformatted("Maintan after: ");
	ImGui::SameLine();
	double remTime = maintainenceTime - runningTime;
	if (remTime > 0)
		ImGui::Text("%2.2f seconds", remTime);
	else
		ImGui::Text("Breakdown for %2.2f seconds", -remTime);
	ImGui::TextUnformatted("Maintainence Cost: ");
	ImGui::SameLine();
	ImGui::Text("%2.2f L.E", maintainenceCost);
	if (ImGui::SmallButton("Maintain"))
	{
		runningTime = 0.0;
		parentBuilding->budget -= maintainenceCost;
	}
#endif
}
