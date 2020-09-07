using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Destroying : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag.Equals("Statue"))
        {
            Destroy(collision.gameObject);
        }
    }

   public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("bulletTrig"))
        {
            Destroy(other.gameObject);
        }
    }
}
