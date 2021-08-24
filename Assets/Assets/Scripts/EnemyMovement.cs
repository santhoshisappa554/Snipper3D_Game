using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
   
    EnemyAggroDetection aggro;
    NavMeshAgent nav;
    Transform enemyTarget;
   
    public static EnemyMovement instance;
    private void Awake()
    {
        instance = this;
        nav = GetComponent<NavMeshAgent>();
       
        aggro = GetComponent<EnemyAggroDetection>();
        aggro.OnAggro += Aggro_OnAggro;
    }
    private void Aggro_OnAggro(Transform target)
    {
        this.enemyTarget = target;
    }
    private void Update()
    {
        if (enemyTarget != null)
        {
            nav.SetDestination(enemyTarget.position);
            float enemySpeed = nav.velocity.magnitude;
            
        }

    }
}
