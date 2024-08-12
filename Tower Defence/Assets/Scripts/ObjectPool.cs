using System;
using System.Collections;
using System.Collections.Generic;
using Unity.EditorCoroutines.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] int poolSize = 3;
    [SerializeField] float enemySpawnTime = 1f;

    GameObject[] pool;

    void Awake(){
        PopulatePool();
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize];
        for(int i=0; i<pool.Length; i++){
            pool[i] = Instantiate(enemy, transform);
            pool[i].SetActive(false);
        }
    }

    void Start()
    {
        StartCoroutine(EnemySpawner());
    }


    void Update()
    {

    }

    IEnumerator EnemySpawner()
    {
        while(poolSize>0){
            // poolSize--;
            EnableObjectsInPool();
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void EnableObjectsInPool()
    {
        for(int i=0;i<pool.Length;i++){
            if(pool[i].activeInHierarchy == false){
                pool[i].SetActive(true);
                return;
            }
        }
    }
}
