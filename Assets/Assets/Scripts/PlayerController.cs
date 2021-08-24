using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float playerSpeed;
    public float backSpeed;
    public float turnSpeed;
    Animator anim;
    EnemyHealth enemyHealth;
    public int score=0;
    bool backMove = false;
    public Text ScoreText;
   
    //AudioSource audioSource;
    //public AudioClip audioClip;

    // Start is called before the first frame update
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        
    }
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizontal, 0, vertical);
        anim.SetFloat("Blend", vertical);



        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);
        if (vertical != 0)
        {
            float moveSpeed = (vertical > 0) ? playerSpeed : backSpeed;
           
            characterController.SimpleMove(transform.forward * vertical * moveSpeed);
            
            
            //audioSource.clip = audioClip;
            //audioSource.Play();
        }
        //Quaternion direction = Quaternion.LookRotation(movement);
        //transform.rotation = Quaternion.Slerp(transform.rotation, direction, Time.deltaTime * turnSpeed); ;
       
      
    }


    
}
