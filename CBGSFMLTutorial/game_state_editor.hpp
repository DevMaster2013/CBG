#pragma once

#include <SFML/Graphics.hpp>

#include "game_state.hpp"
#include "city.hpp"
#include "gui.hpp"

enum class ActionState { NONE, PANNING, SELECTING};

class GameStateEditor : public GameState
{
private:
	ActionState actionState;
	sf::View gameView;
	sf::View guiView;

	City city;

	sf::Vector2i panningAnchor;
	float zoomLevel;

	sf::Vector2i selectionStart;
	sf::Vector2i selectionEnd;
	std::map<std::string, Gui> guiSystem;
	Tile* currentTile;

public:

	virtual void draw(const float dt);
	virtual void update(const float dt);
	virtual void handleInput();

	GameStateEditor(Game* game);
};