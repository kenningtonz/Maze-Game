using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Checkpoints : MonoBehaviour
{

    public GameObject player;
    public GameObject[] checkpoints;
    public GameObject currentcheckpoint;


    void Start()
    {
       
        
    }
   
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


    public void SaveTime(float checkpointtime)
    {
        SaveCheckpointTime(checkpointtime);
    }

    public void resetloggertime()
    {
        ResetLogger();
    }
    public float loadtotaltime()
    {
        return GetTotalTime();
    }

    public float loadtime(int index)
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
   

        for (int i = 0; i < 10; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i))
            {
                Debug.Log(loadtime(i));
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(GetTotalTime());
        }
    }

    private void OnDestroy()
    {
        resetloggertime();
    }


}

