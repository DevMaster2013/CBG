#pragma once
#include "DLLExport.h"
#include "..\GameCore\IRenderable.h"

class GAMERENDER_API CustomGameObject;
class GAMERENDER_API ICustomGameObjectRenderer : public IRenderable
{
protected:
	CustomGameObject* _customGameObject;

public:
	void setCustomGameObject(CustomGameObject* object);
	CustomGameObject* getCustomGameObject() const;

public:
	ICustomGameObjectRenderer(CustomGameObject* object);
	virtual ~ICustomGameObjectRenderer();

public:
	virtual void render() override = 0;
};
