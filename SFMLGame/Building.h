#pragma once

#include "IDrawableInterfaceObject.h"
#include "IUpdatableObject.h"
#include <string>
#include <vector>

class BuildingComponent;
class Building : public IUpdatableObject, IDrawableInterfaceObject
{
public:
	std::string name;
	double budget;
	std::vector<BuildingComponent*> components;

public:
	Building(const std::string& name, double budget);

public:
	virtual void update(double elapsedSeconds) override;
	virtual void drawInterface() override;
	template<typename T> T* getComponent();

protected:
	virtual void onUpdateBuilding(double elapsedSeconds) = 0;
	virtual void onDrawInterfaceBuilding() = 0;
};

#include "Building.inl"
