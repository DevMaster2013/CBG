#pragma once
#include "DLLExport.h"
#include "GameObjectsManager.h"

class GAMECORE_API Game
{
protected:
	bool _isGameActive;
	GameObjectsManager* _gameObjects;

public:
	bool isGameActive() const;

public:
	Game();
	virtual ~Game();

public:
	void startGame();
	void exitGame();

private:
	void initializeGame();
	void updateGame(double elapsedSeconds);
	void handleGameEvents();
	void renderGame();
	void releaseGame();

protected:
	virtual void onInitializeGame();
	virtual void onUpdateGame(double elapsedSeconds);
	virtual void onHandleGameEvents();
	virtual void onRenderGame();
	virtual void onReleaseGame();
};