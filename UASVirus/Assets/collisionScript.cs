﻿using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
    void OnTriggerEnter(Collider col)
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {

            GameObject enemy = Instantiate(Resources.Load("virus2", typeof(GameObject))) as GameObject;
            GameObject enemy1 = Instantiate(Resources.Load("virus2", typeof(GameObject))) as GameObject;
            GameObject enemy2 = Instantiate(Resources.Load("virus2", typeof(GameObject))) as GameObject;
            GameObject enemy3 = Instantiate(Resources.Load("virus2", typeof(GameObject))) as GameObject;

        }
        Destroy(gameObject);
        Destroy(col.gameObject);
    }

}