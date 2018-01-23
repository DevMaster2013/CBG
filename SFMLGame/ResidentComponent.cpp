#include "ResidentComponent.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

ResidentComponent::ResidentComponent(Building * parentBuilding, double housingQuality, size_t capacity)
	: BuildingComponent("Resident", parentBuilding), housingQuality(housingQuality), capacity(capacity)
{
}

void ResidentComponent::onUpdateComponent(double elapsedSeconds)
{
}

void ResidentComponent::onDrawInterfaceComponent()
{
	ImGui::TextUnformatted("Housing Quality: ");
	ImGui::SameLine();
	ImGui::Text("%2.2f", housingQuality);
	ImGui::TextUnformatted("Capacity: ");
	ImGui::SameLine();
	ImGui::Text("%d human", capacity);
}
