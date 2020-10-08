using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextReaderWriter : MonoBehaviour
{
   // TextAsset text;
    string location = "Assets/Stats.txt";

 

    // Start is called before the first frame update
    void Start()
    {
   
    }


    public void writetotext()
    { 
        StreamWriter textwriter = new StreamWriter(location, false);
        for (int i = 0; i < 7; i++)
        {
         textwriter.WriteLine(gameObject.GetComponent<Checkpoints>().loadtime(i));
        }
        textwriter.WriteLine(gameObject.GetComponent<Checkpoints>().loadtotaltime());
        textwriter.Close();
        Debug.Log("writed");
    }

    public void readtext()
    {
    

    }


    // Update is called once per frame
    void Update()
    {
        //adding the lines to a string array
      
     

    }
}
