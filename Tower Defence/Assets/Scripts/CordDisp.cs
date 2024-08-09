using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]
public class CordDisp : MonoBehaviour
{
    Vector2Int coord = new Vector2Int();
    TextMeshPro coordText;

    Waypoint waypoint;



    void Awake(){
        coordText = GetComponent<TextMeshPro>();
        coordText.enabled = false;
        
        waypoint = GetComponentInParent<Waypoint>();
    }

    void Update()
    {
        if(!Application.isPlaying){
            DispCoord();
        }

        ChangeColor();
        ToggleCoord();
    }

    void ToggleCoord()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            coordText.enabled = !coordText.IsActive();
        }
    }

    void ChangeColor()
    {
        if(!waypoint.IsPlaceable){
            coordText.color = Color.gray;
        }
    }

    void DispCoord()
    {
        coord.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coord.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        coordText.text = $"{coord.y}, {coord.x}";
        transform.parent.name = "("+coordText.text+")";
    }
}
