using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUi1 : MonoBehaviour
{
     public GameObject uiObject;
 void Start() {
       uiObject.SetActive(false);

   }

    void OnTriggerEnter(Collider player) {

      if(player.gameObject.tag =="bullet") 
      {
          uiObject.SetActive(true);
          StartCoroutine("WaitForSec");
      }
   }

   IEnumerator WaitForSec()
   {
       yield return new WaitForSeconds(5);
       Destroy(uiObject);
     Destroy(gameObject);
   }
}
