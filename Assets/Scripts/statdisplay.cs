using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statdisplay : MonoBehaviour
{
    public TextAsset textfile;
    private string[] lines;
    public GameObject[] textstatsdisplay;

    void onAwake()
    {

    }
    void Start()
    {
        InvokeRepeating("plswork", 0.5f , 1);
        
    }

    void plswork()
    {
        lines = textfile.text.Split('\n');
        Debug.Log("read from file");

        for (int i = 0; i < 8; i++)
        {
            textstatsdisplay[i].GetComponent<Text>().text = lines[i];
        }
        Debug.Log("updated texts");
    }

    // Update is called once per frame
    void Update()
    {

       
   
    }

}

