using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject gamemanager;
   public bool alreadydone = false;
    float lastTime = 0.0f;


    private void Start()
    {
        lastTime = Time.time;
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (alreadydone == false)
        {
            gamemanager.GetComponent<Score>().setsheckpointcounter(1);
        }
        alreadydone = true;
      
        gamemanager.GetComponent<Checkpoints>().currentcheckpoint = gameObject;
        float currenttime = Time.time;
        float checkpointtime = currenttime - lastTime;
        lastTime = currenttime;

        gamemanager.GetComponent<Checkpoints>().SaveTime(checkpointtime);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
