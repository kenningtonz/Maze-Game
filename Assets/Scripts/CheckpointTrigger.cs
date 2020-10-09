using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject gamemanager;
    public bool alreadydone = false;
    float lastTime = 0.0f;
    WaitForSeconds endtimes = null;
    public GameObject goodjobtext;

    private void Start()
    {
        lastTime = Time.time;
        endtimes = new WaitForSeconds(5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        //only count checkopoint for the first time
        if (alreadydone == false)
        {
            gamemanager.GetComponent<Score>().setsheckpointcounter(1);
            gamemanager.GetComponent<Checkpoints>().currentcheckpoint = gameObject;
            float currenttime = Time.time;
            float checkpointtime = currenttime - lastTime;
            lastTime = currenttime;
            gamemanager.GetComponent<Checkpoints>().SaveTime(checkpointtime);
        }
        alreadydone = true;
      
        //if its the last checkpoint
     if (transform.tag == "End")
        {
            //write to the text file
            gamemanager.GetComponent<TextReaderWriter>().writetotext();

            goodjobtext.SetActive(true);

            //take to end scene
            StartCoroutine(corutine());

        }
    }

    IEnumerator corutine()
    {
        yield return endtimes;
        gamemanager.GetComponent<ChangeScenes>().end();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
