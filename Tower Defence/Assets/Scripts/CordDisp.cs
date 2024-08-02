using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CordDisp : MonoBehaviour
{
    TextMeshPro coordText;
    Vector2Int coord = new Vector2Int();


    void Awake(){
        coordText = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if(!Application.isPlaying){
            DispCoord();
        }
    }

    void DispCoord()
    {
        coord.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coord.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        coordText.text = $"{coord.y},{coord.x}";
        transform.parent.name = coord.ToString();
    }
}
