#include "IronMine.h"
#include "MaintainedComponent.h"
#include "ResidentComponent.h"
#include "ProductionComponent.h"
#include "ProductItem.h"
#include "Product.h"

IronMine::IronMine()
	: Building("Iron Mine", 100000.0)
{
	addComponent(new MaintainedComponent(this, 5.0, 200.0));
	addComponent(new ResidentComponent(this, 20.0, 5));

	ProductionComponent* productionComponent = new ProductionComponent(this, 0.15);
	productionComponent->producedProducts.push_back(new ProductItem(new Product("Iron"), 1.02));
	addComponent(productionComponent);
}

void IronMine::onUpdateBuilding(double elapsedSeconds)
{
}

void IronMine::onDrawInterfaceBuilding()
{
}
