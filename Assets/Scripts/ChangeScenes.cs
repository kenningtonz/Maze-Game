using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update
   public void play()
    {
        SceneManager.LoadScene("PlayScene");
        //Debug.Log("play");
    }

    public void end()
    {
        SceneManager.LoadScene("EndScene");
       //Debug.Log("end");
    }

    public void start()
    {
        SceneManager.LoadScene("StartScene");
       // Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
