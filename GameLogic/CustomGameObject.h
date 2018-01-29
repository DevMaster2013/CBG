#pragma once
#include "DLLExport.h"
#include "..\GameCore\GameObject.h"

class GAMELOGIC_API CustomGameObject : public GameObject
{
private:
	double _internalGameState;

public:
	double getInternalGameState() const;

public:
	CustomGameObject();
	~CustomGameObject();

protected:
	virtual void onInitialize() override;
	virtual void onHandleEvents() override;
	virtual void onUpdate(double elapsedSeconds) override;
	virtual void onRender() override;
	virtual void onRelease() override;
};