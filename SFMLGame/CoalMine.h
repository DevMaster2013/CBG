#pragma once

#include "Building.h"

class CoalMine : public Building
{
public:
	CoalMine();

private:
	virtual void onUpdateBuilding(double elapsedSeconds) override;
	virtual void onDrawInterfaceBuilding() override;
};