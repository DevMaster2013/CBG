#include "ProductionComponent.h"
#include "Building.h"
#include "ProductItem.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

ProductionComponent::ProductionComponent(Building * parentBuilding, double productionRate)
	: BuildingComponent("Production", parentBuilding)
	, totalProduction(0.0)
	, productionRate(productionRate)
{
}

void ProductionComponent::onUpdateComponent(double elapsedSeconds)
{
	totalProduction = 0.0;
	for (size_t i = 0; i < producedProducts.size(); i++)
	{
		producedProducts[i]->quantity += productionRate * elapsedSeconds;
		totalProduction += producedProducts[i]->quantity;
	}
}

void ProductionComponent::onDrawInterfaceComponent()
{
	ImGui::TextUnformatted("Total Production: ");
	ImGui::SameLine();
	ImGui::Text("%2.2f ton", totalProduction);
	ImGui::TextUnformatted("Production Rate: ");
	ImGui::SameLine();
	ImGui::Text("%2.2f ton/second", productionRate);	
	if (ImGui::BeginChild("Produced Products"))
	{
		for (size_t i = 0; i < producedProducts.size(); i++)
			producedProducts[i]->drawInterface();
	}
	ImGui::EndChild();
}
