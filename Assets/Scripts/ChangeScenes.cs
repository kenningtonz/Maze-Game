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
    }

    public void end()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void start()
    {
        SceneManager.LoadScene("StartScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
