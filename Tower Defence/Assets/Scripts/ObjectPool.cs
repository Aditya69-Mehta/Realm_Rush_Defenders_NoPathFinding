using System;
using System.Collections;
using System.Collections.Generic;
using Unity.EditorCoroutines.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] int numEnemy = 1;
    [SerializeField] float enemySpawnTime = 1f;


    void Start()
    {
        StartCoroutine(EnemySpawner());
    }


    void Update()
    {

    }

    IEnumerator EnemySpawner()
    {
        while(numEnemy>0){
            Instantiate(enemy, transform);
            numEnemy--;
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }
}
