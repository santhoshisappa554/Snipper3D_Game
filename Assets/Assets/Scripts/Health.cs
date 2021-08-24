using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    int startHealth = 5;
    [SerializeField]
    int currentHealth;
    public Text playerHEalthText;
    private void OnEnable()
    {
        currentHealth = startHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        print(currentHealth);
        playerHEalthText.text = "Health: " + currentHealth;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        gameObject.SetActive(false);
        
        SceneManager.LoadScene(5);
    }
}
