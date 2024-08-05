using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] int maxHealth = 5;
    // int currHealth;

    void Start()
    {
        // currHealth=maxHealth;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        maxHealth--;
        if (maxHealth < 1) Destroy(gameObject);
    }
}
