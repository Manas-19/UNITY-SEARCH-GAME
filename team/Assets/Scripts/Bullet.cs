using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public bool createForce = true;
    public bool shouldExplode = false;
    public float LifeTime = 10f;

    public float power = 10.0f;
    public float radius = 5.0f;
    public float upwardsThrust = 3.0f;

    public GameObject Explosion;

    private Collider[] overlappers; 
       
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(LifeTime>0)
        {
            LifeTime -= Time.deltaTime;
        }

        if(LifeTime<=0)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        if(createForce)
        {
            rb.AddForce(transform.forward * thrust);
                createForce = false;
        }

        if(shouldExplode)
        {
            Collider[] colliders = GetOverlappers();


            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    rb.AddExplosionForce(power, this.transform.position, radius, upwardsThrust);

                }
            }
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        shouldExplode = true;
        Instantiate(Explosion, this.transform.position, this.transform.rotation);
    }

    Collider[] GetOverlappers()
    {
        return Physics.OverlapSphere(this.transform.position, radius);
    }
}
