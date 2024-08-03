using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;


    void Start()
    {
        // Debug.Log("Initiated Start");
        StartCoroutine(FollowWaypoint());
        // Debug.Log("Start Ended");
    }

    IEnumerator FollowWaypoint()
    {
        foreach(Waypoint waypoint in path){
            // Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
