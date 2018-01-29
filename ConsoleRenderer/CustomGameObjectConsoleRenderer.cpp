#include "CustomGameObjectConsoleRenderer.h"
#include "..\GameLogic\CustomGameObject.h"
#include <iostream>

CustomGameObjectConsoleRenderer::CustomGameObjectConsoleRenderer(CustomGameObject * object)
	: ICustomGameObjectRenderer(object)
{
}

CustomGameObjectConsoleRenderer::~CustomGameObjectConsoleRenderer()
{
}

void CustomGameObjectConsoleRenderer::render()
{
	std::cout << "Game Object Internal State = " << _customGameObject->getInternalGameState() << "\r";
}
