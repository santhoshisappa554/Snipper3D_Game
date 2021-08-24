using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyShooting : MonoBehaviour
{
    EnemyAggroDetection aggroDetect;
    private Health healthTarget;
    [SerializeField]
    private float attackTimer;
    [SerializeField]
    private float attackRefreshRate = 1f;
   

    private void Awake()
    {
        aggroDetect = GetComponent<EnemyAggroDetection>();
        aggroDetect.OnAggro += AggroDetect_OnAggro;
    }

    private void AggroDetect_OnAggro(Transform target)
    {
        Health health = target.GetComponent<Health>();
        if (health != null)
        {
            healthTarget = health;
        }
    }
    private void Update()
    {
        if (healthTarget != null)
        {
            attackTimer += Time.deltaTime;
            if (CanAttack())
            {
                Attack();
            }
        }
    }

    private void Attack()
    {
        attackTimer = 0f;
        healthTarget.TakeDamage(1);
       
    }

    private bool CanAttack()
    {
        return attackTimer >= attackRefreshRate;
    }
}
