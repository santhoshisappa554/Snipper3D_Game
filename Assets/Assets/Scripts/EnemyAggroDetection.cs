using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
public class EnemyAggroDetection : MonoBehaviour
{
    Animator anim;
    public event Action<Transform> OnAggro = delegate { };
    public float enemySpeed;
    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            Debug.Log("Aggro detector");
            OnAggro(player.transform);
            anim.SetFloat("Blend", enemySpeed);
        }
    }
}
