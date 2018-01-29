#pragma once

#pragma warning( push )
#pragma warning( disable : 4251)

#ifndef OPENGLRENDERER_EXPORTS
#define OPENGLRENDERER_API __declspec(dllimport)
#else
#define OPENGLRENDERER_API __declspec(dllexport)
#endif