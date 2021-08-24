using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float enemySpeed;
   // Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name=="Enemy7" || gameObject.name == "Enemy4"|| gameObject.name == "Enemy1"|| gameObject.name == "Enemy2")
        {
            transform.Translate(enemySpeed * Vector3.forward * Time.deltaTime);
        }
    }
}
