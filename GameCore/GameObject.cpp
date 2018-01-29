#include "GameObject.h"

bool GameObject::isVisible() const
{
	return _isVisible;
}

void GameObject::setVisible(bool visible)
{
	_isVisible = visible;
}

GameObject::GameObject()
	: _objectRenderable(nullptr)
	, _isVisible(true)
{
}

GameObject::~GameObject()
{
}

void GameObject::initialize()
{
	onInitialize();
}

void GameObject::handleEvents()
{
	onHandleEvents();
}

void GameObject::update(double elapsedSeconds)
{
	onUpdate(elapsedSeconds);
}

void GameObject::render()
{
	if (!_isVisible) return;
	onRender();
	if (_objectRenderable)
		_objectRenderable->render();
}

void GameObject::release()
{
	onRelease();

	if (_objectRenderable)
		delete _objectRenderable;
	_objectRenderable = nullptr;
}

void GameObject::onInitialize()
{
}

void GameObject::onHandleEvents()
{
}

void GameObject::onUpdate(double elapsedSeconds)
{
}

void GameObject::onRender()
{
}

void GameObject::onRelease()
{
}
