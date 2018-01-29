#include "GameObjectsManager.h"

GameObjectsManager::GameObjectsManager()
{
}

GameObjectsManager::~GameObjectsManager()
{
}

void GameObjectsManager::addGameObject(const std::string & name, GameObject * object)
{
	_gameObjects[name] = object;
}

void GameObjectsManager::removeGameObject(const std::string & name)
{
	_gameObjects.erase(name);
}

GameObject * GameObjectsManager::getGameObject(const std::string & name)
{
	return _gameObjects[name];
}

void GameObjectsManager::initialize()
{
	for each (auto& object in _gameObjects)
		object.second->initialize();
}

void GameObjectsManager::handleEvents()
{
	for each (auto& object in _gameObjects)
		object.second->handleEvents();
}

void GameObjectsManager::update(double elapsedSeconds)
{
	for each (auto& object in _gameObjects)
		object.second->update(elapsedSeconds);
}

void GameObjectsManager::render()
{
	for each (auto& object in _gameObjects)
		object.second->render();
}

void GameObjectsManager::release()
{
	for each (auto& object in _gameObjects)
		object.second->release();
	_gameObjects.clear();
}
