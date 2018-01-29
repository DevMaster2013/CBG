#pragma once
#include "DLLExport.h"
#include "..\GameRender\ICustomGameObjectRenderer.h"

class CONSOLERENDERER_API CustomGameObjectConsoleRenderer : public ICustomGameObjectRenderer
{
public:
	CustomGameObjectConsoleRenderer(CustomGameObject* object);
	~CustomGameObjectConsoleRenderer();

public:
	virtual void render() override;
};