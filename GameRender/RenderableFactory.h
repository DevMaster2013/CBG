#pragma once
#include "DLLExport.h"
#include "IRenderableFactory.h"

class GAMERENDER_API RenderableFactory
{
private:
	static IRenderableFactory* _rendererFactory;

public:
	static void setRenderableFactory(IRenderableFactory* rendererFactory);
	static IRenderableFactory* getRenderableFactory();
};
