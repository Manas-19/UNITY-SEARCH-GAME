using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody myBody;
    private float LifeTimer = 0.5f;
    private float timer;
    private bool hitSomething = false;
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.LookRotation(myBody.velocity);
    }

    
    private void Update()
    {
        
        if (!hitSomething)
        {
            transform.rotation = Quaternion.LookRotation(myBody.velocity);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void Stick()
    {
        myBody.constraints = RigidbodyConstraints.FreezeAll;
    }
}
