#include "RenderableFactory.h"
#include "..\ConsoleRenderer\ConsoleRendererFactory.h"

IRenderableFactory* RenderableFactory::_rendererFactory = nullptr;

void RenderableFactory::setRenderableFactory(IRenderableFactory * rendererFactory)
{
	if (_rendererFactory)
		delete _rendererFactory;
	_rendererFactory = rendererFactory;
}

IRenderableFactory * RenderableFactory::getRenderableFactory()
{
	return _rendererFactory;
}
