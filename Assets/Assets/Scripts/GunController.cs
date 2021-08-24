using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GunController : MonoBehaviour
{
    float fireRate = 1f;
    int damage = 1;
    public float timer = 20;
    [SerializeField] Transform firePoint;
    [SerializeField] ParticleSystem particle;
    AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    PlayerController player;
    public Text timeText;
    public Text scoreText;
    //public GameObject BulletPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //audioSource.Play();
        timer -= Time.deltaTime;
        timeText.text = "Time: " + Mathf.RoundToInt(timer);

        if (timer > fireRate)
        {
            if (Input.GetMouseButton(0))
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                particle.Play();
                //timer = 0;
                FireGun();
            }
        }
            
            
       
        else if (timer <= 0)
        {
            print("Game End");
            SceneManager.LoadScene(5);
        }

    }

    public void FireGun()
    {
        Debug.DrawRay(player.transform.position, player.transform.forward * 30.0f, Color.blue, 1f);
        Ray ray = new Ray(player.transform.position, player.transform.forward);
        
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
                //var bulletProjectile = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
                var health = hit.collider.gameObject.GetComponent<EnemyHealth>();
                if (health != null)
                {
                    health.TakeDamage(1);
                }

            if (hit.collider.CompareTag("Enemy"))
            {

               
                SceneManager.LoadScene(6);

            }
            else if(hit.collider.CompareTag("Enemy1") )
            {

                SceneManager.LoadScene(5);
            }
            
                
           
        }
    }
    
 
    
}