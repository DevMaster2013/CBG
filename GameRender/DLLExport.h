#pragma once

#pragma warning( push )
#pragma warning( disable : 4251)

#ifndef GAMERENDER_EXPORTS
#define GAMERENDER_API __declspec(dllimport)
#else
#define GAMERENDER_API __declspec(dllexport)
#endif