#pragma once

class IUpdatableObject
{
public:
	virtual void update(double elapsedSeconds) = 0;
};