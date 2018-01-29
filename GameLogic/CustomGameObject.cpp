#include "CustomGameObject.h"
#include "..\GameRender\RenderableFactory.h"

double CustomGameObject::getInternalGameState() const
{
	return _internalGameState;
}

CustomGameObject::CustomGameObject()
	: _internalGameState(0.0)
{
	_objectRenderable = (IRenderable*)RenderableFactory::getRenderableFactory()->getCustomGameObjectRenderable(this);
}

CustomGameObject::~CustomGameObject()
{
}

void CustomGameObject::onInitialize()
{
}

void CustomGameObject::onHandleEvents()
{
}

void CustomGameObject::onUpdate(double elapsedSeconds)
{
	_internalGameState += elapsedSeconds;
}

void CustomGameObject::onRender()
{
}

void CustomGameObject::onRelease()
{
}
