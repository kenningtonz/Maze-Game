#include "CheckPoint.h"

void CheckPoint::ResetLogger()
{
	//used to unload dll, because unity is dumb
	m_RTBC.clear();
	m_TRT = 0.0f;
}

void CheckPoint::SaveCheckpointTime(float RTBC)
{
	m_RTBC.push_back(RTBC);
	m_TRT += RTBC;
}

float CheckPoint::GetTotalTime()
{
	return m_TRT;
}

float CheckPoint::GetCheckpointTime(int index)
{
	return m_RTBC[index];
}

int CheckPoint::GetNumCheckpoints()
{
	return m_RTBC.size();
}
