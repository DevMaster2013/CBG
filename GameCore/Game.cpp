#include "Game.h"
#include "..\GameRender\RenderableFactory.h"
#include <chrono>

bool Game::isGameActive() const
{
	return _isGameActive;
}

Game::Game()
	: _isGameActive(false)
	, _gameObjects(nullptr)
{

}

Game::~Game()
{

}

void Game::startGame()
{	
	initializeGame();	

	const double updateFrameRate = 1.0 / 60.0;
	std::chrono::high_resolution_clock::time_point currentTime = std::chrono::high_resolution_clock::now();
	while (_isGameActive)
	{
		std::chrono::high_resolution_clock::time_point loopTime = std::chrono::high_resolution_clock::now();
		std::chrono::duration<double> timeSpan = std::chrono::duration_cast<std::chrono::duration<double>>(loopTime - currentTime);
		double elapsedSeconds = timeSpan.count();
		if (elapsedSeconds > updateFrameRate)
		{
			handleGameEvents();
			updateGame(elapsedSeconds);
			renderGame();

			currentTime = loopTime;
		}
	}

	releaseGame();
}

void Game::exitGame()
{
	_isGameActive = false;
}

void Game::initializeGame()
{
	_isGameActive = true;
	_gameObjects = new GameObjectsManager();	

	onInitializeGame();

	_gameObjects->initialize();
}

void Game::updateGame(double elapsedSeconds)
{
	_gameObjects->update(elapsedSeconds);

	onUpdateGame(elapsedSeconds);
}

void Game::handleGameEvents()
{
	_gameObjects->handleEvents();

	onHandleGameEvents();
}

void Game::renderGame()
{	
	onRenderGame();

	_gameObjects->render();
}

void Game::releaseGame()
{
	onReleaseGame();

	_gameObjects->release();
}

void Game::onInitializeGame()
{
}

void Game::onUpdateGame(double elapsedSeconds)
{
}

void Game::onHandleGameEvents()
{
}

void Game::onRenderGame()
{
}

void Game::onReleaseGame()
{
}