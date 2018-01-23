#include "BuildingComponent.h"
#include "Building.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

BuildingComponent::BuildingComponent(const std::string & name, Building * parentBuilding)
	: name(name)
	, parentBuilding(parentBuilding)
{
}

void BuildingComponent::update(double elapsedSeconds)
{
	onUpdateComponent(elapsedSeconds);
}

void BuildingComponent::drawInterface()
{
	ImGui::Separator();
	onDrawInterfaceComponent();
	ImGui::Separator();
}
