using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] int maxHealth = 5;
    int currHealth;
    Enemy enemy;

    void Start(){
        enemy = FindObjectOfType<Enemy>();
    }

    void OnEnable()
    {
        currHealth=maxHealth;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currHealth--;
        if (currHealth < 1){
            enemy.Reward();
            gameObject.SetActive(false);
        }
    }
}
