#pragma once

#pragma warning( push )
#pragma warning( disable : 4251)

#ifndef GAMECORE_EXPORTS
#define GAMECORE_API __declspec(dllimport)
#else
#define GAMECORE_API __declspec(dllexport)
#endif
