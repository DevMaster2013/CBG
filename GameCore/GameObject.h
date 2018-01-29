#pragma once
#include "DLLExport.h"
#include "IRenderable.h"

class GAMECORE_API GameObject
{
protected:
	IRenderable* _objectRenderable;
	bool _isVisible;

public:
	bool isVisible() const;
	void setVisible(bool visible);

public:
	GameObject();
	virtual ~GameObject();

public:
	void initialize();
	void handleEvents();
	void update(double elapsedSeconds);
	void render();
	void release();

protected:
	virtual void onInitialize();
	virtual void onHandleEvents();
	virtual void onUpdate(double elapsedSeconds);
	virtual void onRender();
	virtual void onRelease();
};