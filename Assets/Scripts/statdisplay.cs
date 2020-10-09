using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statdisplay : MonoBehaviour
{
    public TextAsset textfile;
    private string[] lines;
    public GameObject[] textstatsdisplay;

    void Start()
    {
        InvokeRepeating("plswork", 0.5f , 1);
        
    }

    void plswork()
    {
        lines = textfile.text.Split('\n');

        for (int i = 0; i < 8; i++)
        {
            textstatsdisplay[i].GetComponent<Text>().text = lines[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

       
   
    }

}

