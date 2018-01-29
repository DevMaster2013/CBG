#pragma once
#include "DLLExport.h"

class GAMERENDER_API ICustomGameObjectRenderer;
class GAMERENDER_API CustomGameObject;

class GAMERENDER_API IRenderableFactory
{
public:
	virtual ICustomGameObjectRenderer* getCustomGameObjectRenderable(CustomGameObject* object) = 0;
};
