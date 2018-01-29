#pragma once
#include "DLLExport.h"
#include "..\GameRender\IRenderableFactory.h"

class CONSOLERENDERER_API ConsoleRendererFactory : public IRenderableFactory
{
public:
	virtual ICustomGameObjectRenderer* getCustomGameObjectRenderable(CustomGameObject * object) override;
};
