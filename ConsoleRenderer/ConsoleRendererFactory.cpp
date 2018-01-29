#include "ConsoleRendererFactory.h"
#include "CustomGameObjectConsoleRenderer.h"

ICustomGameObjectRenderer * ConsoleRendererFactory::getCustomGameObjectRenderable(CustomGameObject * object)
{
	return new CustomGameObjectConsoleRenderer(object);
}
