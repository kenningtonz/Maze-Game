using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTester : MonoBehaviour
{
    float lastTime = 0.0f;
   // int setcheckpoints = 5;
    void Start()
    {
        lastTime = Time.time;
    }
    // Start is called before the first frame update
    private const string DLL_NAME = "EnginesDLLMidterm";

    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoints();

  
    public void SaveTimeTest(float checkpointtime)
    {
        SaveCheckpointTime(checkpointtime);
     }
  
    public void resetloggertimetest()
    {
        ResetLogger();
    }
    public float loadtotaltimetest()
    {
        return GetTotalTime();
    }

    public float loadtimetest(int index)
    {
        if (index >= GetNumCheckpoints())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }
      

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currenttime = Time.time;
            float checkpointtime = currenttime - lastTime;
            lastTime = currenttime;

            SaveTimeTest(checkpointtime);
        }
       

        for (int i = 0; i <10; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha0+i))
            {
                Debug.Log(loadtimetest(i));
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(GetTotalTime());
        }
    }

    private void OnDestroy()
    {
        resetloggertimetest();
    }
}
