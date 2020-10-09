using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private int direction = 1;
    private Vector3 initalpostiion;
    private float maxmovedx;
    private float maxmovedz;

    void Start()
    {
        initalpostiion = transform.position;
        maxmovedx = initalpostiion.x + 2.0f;
        maxmovedz = initalpostiion.z + 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.tag == "MoveX")
        { 
            if (transform.position.x > maxmovedx)
            {
                direction = -1;
            }
            if (transform.position.x < initalpostiion.x)
            {
                direction = 1;
            }

            transform.Translate(new Vector3(direction * speed * Time.deltaTime, 0, 0));
        }

        if (transform.tag == "MoveZ")
        {
            if (transform.position.z > maxmovedz)
            {
                direction = -1;
            }
            if (transform.position.z < initalpostiion.z)
            {
                direction = 1;
            }

            transform.Translate(new Vector3(0,0, direction * speed * Time.deltaTime));
        }
    }
}
