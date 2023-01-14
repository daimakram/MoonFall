using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class moveman : MonoBehaviour
{
 public Transform waypoint1;
 public Transform waypoint2;
 private int currentWaypoint = 1;
 private Transform targetWaypoint;
 public float speed = 4f;
 void Update()
 {
    if (currentWaypoint == 1)
    {
        targetWaypoint = waypoint2;
        Move();
    }
    else if (currentWaypoint == 2)
    {
        targetWaypoint = waypoint1;
        Move();
    }
 }
 void Move()
 {
    // move towards the target
    transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);
    //look towards the target
    if (transform.position == waypoint1.position)
    {
    currentWaypoint = 1;
    transform.Rotate(transform.rotation.x*-1,transform.rotation.y,transform.rotation.z);
    }
    else if (transform.position == waypoint2.position)
    {
    currentWaypoint = 2;
    transform.Rotate(transform.rotation.x*-1,transform.rotation.y,transform.rotation.z);
    }
 }
}
