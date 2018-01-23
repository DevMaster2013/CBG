#pragma once

#include "BuildingComponent.h"

class ResidentComponent : public BuildingComponent
{
public:
	double housingQuality;
	size_t capacity;

public:
	ResidentComponent(Building* parentBuilding, double housingQuality, size_t capacity);

private:
	virtual void onUpdateComponent(double elapsedSeconds) override;
	virtual void onDrawInterfaceComponent() override;
};