using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextReaderWriter : MonoBehaviour
{
   // TextAsset text;
    string location = "Assets/Stats.txt";



    public void writetotext()
    { 
        StreamWriter textwriter = new StreamWriter(location, false);
        for (int i = 0; i < 7; i++)
        {
         textwriter.WriteLine(gameObject.GetComponent<Checkpoints>().loadtime(i));
        }
        textwriter.WriteLine(gameObject.GetComponent<Checkpoints>().loadtotaltime());
        textwriter.Close();
    }

    public void readtext()
    {
    

    }


    // Update is called once per frame
    void Update()
    {
      
    
    }
}
