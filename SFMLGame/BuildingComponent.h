#pragma once

#include "IUpdatableObject.h"
#include "IDrawableInterfaceObject.h"
#include <string>

class Building;
class BuildingComponent : public IUpdatableObject, IDrawableInterfaceObject
{
public:
	std::string name;
	Building* parentBuilding;

public:
	BuildingComponent(const std::string& name, Building* parentBuilding);

public:
	virtual void update(double elapsedSeconds) override;
	virtual void drawInterface() override;

protected:
	virtual void onUpdateComponent(double elapsedSeconds) = 0;
	virtual void onDrawInterfaceComponent() = 0;
};