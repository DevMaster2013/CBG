#pragma once

#pragma warning( push )
#pragma warning( disable : 4251)

#ifndef CONSOLERENDERER_EXPORTS
#define CONSOLERENDERER_API __declspec(dllimport)
#else
#define CONSOLERENDERER_API __declspec(dllexport)
#endif