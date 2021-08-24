using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    int startHealth = 5;
    [SerializeField]
    public int currentHealth;
    public int score = 0;
    public static EnemyHealth instance1;


    //public Text playerHEalthText;
    private void OnEnable()
    {
        currentHealth = startHealth;
    }
    private void Awake()
    {
        instance1 = this;
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        //playerHEalthText.text = "Health: " + currentHealth;
        if (currentHealth <= 0)
        {

            Die();
        }
    }
    public void Die()
    {

        gameObject.SetActive(false);
        //print("EnemyDead");

       
        
    }
}
