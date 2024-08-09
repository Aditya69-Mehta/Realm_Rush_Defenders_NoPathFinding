using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable {
        get{ // Like A Getter But Property. 
            return isPlaceable;
        }
    }

    void OnMouseDown(){
        if(isPlaceable){
            // Debug.Log(name);
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceable=false;
        }
    }
}
