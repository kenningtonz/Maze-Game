#pragma once
#ifndef __WRAPPER__
#define __WRAPPER__

#include "PluginSettings.h"
#include "CheckPoint.h"

#ifdef __cplusplus
extern "C"
{
#endif
	//put functions here
	 
	//resets logger
	PLUGIN_API void ResetLogger();

	//save most recent checkpoint time
	PLUGIN_API void SaveCheckpointTime(float RTBC);

	//gets total time
	PLUGIN_API float GetTotalTime();

	//gets total time for race
	PLUGIN_API float GetCheckpointTime(int index);

	//gets the number of checkpoints
	PLUGIN_API int GetNumCheckpoints();

#ifdef __cplusplus
}
#endif

#endif /* defined (__WRAPPER__) */



