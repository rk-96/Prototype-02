﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; // time the player has to wait to fire again , 1 is wait , 0 no wait
    private float nextFire = 0; // time since start after which player can fire

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has elapsed since last fire, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // reset nextFire to current time + fireRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
