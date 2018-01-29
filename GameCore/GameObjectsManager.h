#pragma once

#include "DLLExport.h"
#include "GameObject.h"
#include <string>
#include <unordered_map>

class GAMECORE_API GameObjectsManager
{
private:
	std::unordered_map<std::string, GameObject*> _gameObjects;

public:
	GameObjectsManager();
	~GameObjectsManager();

public:
	void addGameObject(const std::string& name, GameObject* object);
	void removeGameObject(const std::string& name);
	GameObject* getGameObject(const std::string& name);

public:
	void initialize();
	void handleEvents();
	void update(double elapsedSeconds);
	void render();
	void release();
};
