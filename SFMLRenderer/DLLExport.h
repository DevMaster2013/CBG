#pragma once

#pragma warning( push )
#pragma warning( disable : 4251)

#ifndef SFMLRENDERER_EXPORTS
#define SFMLRENDERER_API __declspec(dllimport)
#else
#define SFMLRENDERER_API __declspec(dllexport)
#endif