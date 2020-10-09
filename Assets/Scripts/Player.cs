using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float lookspeed;



    // Update is called once per frame
    void Update()
    {
       

        //movement


        //move right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        //move left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        //move backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        //move forwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
 

        /////////////
        //Looking

        //look left
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -lookspeed * Time.deltaTime, 0));
        }

        //look right
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, lookspeed * Time.deltaTime, 0));
        }

      
    }
}
