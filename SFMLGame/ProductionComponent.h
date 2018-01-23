#pragma once

#include "BuildingComponent.h"
#include <vector>

class ProductItem;
class ProductionComponent : public BuildingComponent
{
public:
	double totalProduction;
	double productionRate;
	std::vector<ProductItem*> producedProducts;

public:
	ProductionComponent(Building* parentBuilding, double productionRate);

private:
	virtual void onUpdateComponent(double elapsedSeconds) override;
	virtual void onDrawInterfaceComponent() override;
};