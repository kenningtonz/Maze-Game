using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject gamemanager;
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        //respawn
        player.transform.position = gamemanager.GetComponent<Checkpoints>().currentcheckpoint.transform.position;
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
