#include "ICustomGameObjectRenderer.h"

void ICustomGameObjectRenderer::setCustomGameObject(CustomGameObject * object)
{
	_customGameObject = object;
}

CustomGameObject * ICustomGameObjectRenderer::getCustomGameObject() const
{
	return _customGameObject;
}

ICustomGameObjectRenderer::ICustomGameObjectRenderer(CustomGameObject * object)
	: _customGameObject(object)
{
}

ICustomGameObjectRenderer::~ICustomGameObjectRenderer()
{
}
