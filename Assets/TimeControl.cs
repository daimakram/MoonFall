using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeControl : MonoBehaviour
{
 public float timeElapsed;
 public bool startTimer;
 public bool completedLevel;
 public Text timeText;
 public GameObject car;
 public GameObject lose;
 void Start()
 {
 timeElapsed = 0;
 completedLevel = false;
 car = GameObject.FindGameObjectWithTag("Player");
 }
 void Update()
 {

 if(timeElapsed>=300 && car.GetComponent<PublicCollect>().output < 10){
     startTimer=false;
     //LOSE
     lose.SetActive(true);
     car.SetActive(false);
     Debug.Log("Ended");
 }
 if (startTimer)
 {
 timeElapsed += Time.deltaTime;
 double sec=(int)((300-timeElapsed)%60);
 double min = (int)((300-timeElapsed)/60);
 timeText.text = "Time Remaining: "+min.ToString()+":"+sec.ToString();
 }
 if (completedLevel)
 {
 double output = System.Math.Round(timeElapsed);
 double sec=(int)((timeElapsed)%60);
 double min = (int)((timeElapsed)/60);
 timeText.text = "Completed in "+min.ToString()+":"+sec.ToString();
 }
 }
 public void Startbutton()
 {
 startTimer = true;
 timeElapsed = 0;
 Debug.Log("Started");
 Debug.Log(startTimer);
 Debug.Log(timeElapsed);
 }
}
