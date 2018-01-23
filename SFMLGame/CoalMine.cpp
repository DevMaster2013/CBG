#include "CoalMine.h"
#include "MaintainedComponent.h"
#include "ResidentComponent.h"
#include "ProductionComponent.h"
#include "ProductItem.h"
#include "Product.h"

CoalMine::CoalMine()
	: Building("Coal Mine", 50000.0)
{	
	addComponent(new MaintainedComponent(this, 10.0, 100.0));
	addComponent(new ResidentComponent(this, 10.0, 5));

	ProductionComponent* productionComponent = new ProductionComponent(this, 0.15);
	productionComponent->producedProducts.push_back(new ProductItem(new Product("Coal"), 1.12));
	addComponent(productionComponent);
}

void CoalMine::onUpdateBuilding(double elapsedSeconds)
{
}

void CoalMine::onDrawInterfaceBuilding()
{
}
