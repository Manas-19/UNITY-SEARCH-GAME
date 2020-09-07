using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class COUNTTIME : MonoBehaviour
{
    float currenttime= 0f;
  float starttime= 10f;

   [SerializeField] Text countdowntext;


public void Start()
{
currenttime=starttime;
}

public void Update()
{
    currenttime -= 1 * Time.deltaTime;
    countdowntext.text = currenttime.ToString("f2");

    if(currenttime <=0){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
}
