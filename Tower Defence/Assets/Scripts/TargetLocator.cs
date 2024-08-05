using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{

    [SerializeField] Transform weapon;
    Transform target;

    void Start()
    {
        target = FindAnyObjectByType<EnemyMovement>().transform;
    }


    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
