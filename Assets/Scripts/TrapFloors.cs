using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFloors : MonoBehaviour
{
    public float speed;
    private bool ismoving = false;

    private void OnTriggerEnter(Collider other)
    {
        ismoving = true;
        GetComponent<Animation>().Play();

    }



        // Update is called once per frame
        void Update()
    {
        
        if (ismoving == true)
        {
            transform.Translate(0, -speed * Time.deltaTime,0 );
        }

    }
}
