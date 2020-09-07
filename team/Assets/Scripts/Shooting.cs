﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject aim;
    public GameObject arrowPrefab;
    public Transform arrowSpawn;
    public float shootForce = 20f;
     
    

    void start()
    {
      

    }
 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(arrowPrefab, arrowSpawn.position, Quaternion.identity);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.velocity = aim.transform.forward * shootForce;
           
               
        }
    }
}
