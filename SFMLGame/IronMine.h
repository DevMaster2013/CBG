#pragma once

#include "Building.h"

class IronMine : public Building
{
public:
	IronMine();

private:
	virtual void onUpdateBuilding(double elapsedSeconds) override;
	virtual void onDrawInterfaceBuilding() override;
};