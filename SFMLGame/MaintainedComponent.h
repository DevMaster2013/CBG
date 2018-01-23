#pragma once

#include "BuildingComponent.h"

class MaintainedComponent : public BuildingComponent
{
public:
	double maintainenceTime;
	double maintainenceCost;

private:
	double runningTime;

public:
	MaintainedComponent(Building* parentBuilding, double maintainenceTime, double maintainenceCost);

public:
	bool isWorking();

private:
	virtual void onUpdateComponent(double elapsedSeconds) override;
	virtual void onDrawInterfaceComponent() override;
};