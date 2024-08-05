using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    [SerializeField] GameObject towerPrefab;

    void OnMouseDown(){
        if(isPlaceable){
            // Debug.Log(name);
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceable=false;
        }
    }
}
