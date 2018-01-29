#pragma once

#pragma warning( push )
#pragma warning( disable : 4251)

#ifndef GAMELOGIC_EXPORTS
#define GAMELOGIC_API __declspec(dllimport)
#else
#define GAMELOGIC_API __declspec(dllexport)
#endif