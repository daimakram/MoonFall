using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeElapse : MonoBehaviour
{
 public Text timeText;
 public GameObject win;
 private GameObject obj;


void Start(){
    obj= GameObject.FindGameObjectWithTag("Player");
}
 void OnTriggerEnter(Collider other)
 {
 if(obj.GetComponent<PublicCollect>().output >= 10)
 {
     obj.GetComponent<TimeControl>().startTimer = false;
     obj.GetComponent<TimeControl>().completedLevel = true;
     Debug.Log("You Win");
     win.SetActive(true);
     obj.SetActive(false);

 }
 }
}
