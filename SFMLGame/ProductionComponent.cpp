#include "ProductionComponent.h"
#include "Building.h"
#include "ProductItem.h"

#include <SFML\Graphics.hpp>
#include <imgui.h>
#include <imgui-SFML.h>

ProductionComponent::ProductionComponent(Building * parentBuilding, double totalProduction, double productionRate)
	: BuildingComponent("Production", parentBuilding), totalProduction(totalProduction), productionRate(productionRate)
{
}

void ProductionComponent::onUpdateComponent(double elapsedSeconds)
{
	totalProduction += productionRate * elapsedSeconds;
}

void ProductionComponent::onDrawInterfaceComponent()
{
	ImGui::TextUnformatted("Total Production: ");
	ImGui::SameLine();
	ImGui::Text("%2.2f ton", totalProduction);
	ImGui::TextUnformatted("Production Rate: ");
	ImGui::SameLine();
	ImGui::Text("%2.2f ton/second", productionRate);
	ImGui::Separator();
	if (ImGui::SmallButton("+"))
		productionRate += 0.1;
	ImGui::SameLine();
	if (ImGui::SmallButton("-"))
	{
		productionRate -= 0.1;
		if (productionRate < 0.0)
			productionRate = 0.0;
	}
	if (ImGui::BeginChild("Produced Products"))
	{
		for (size_t i = 0; i < producedProducts.size(); i++)
			producedProducts[i]->drawInterface();
	}
	ImGui::EndChild();
}
