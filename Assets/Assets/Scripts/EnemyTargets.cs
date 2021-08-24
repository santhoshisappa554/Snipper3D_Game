using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTargets : MonoBehaviour
{
    public GameObject[] enemyList;
    public static EnemyTargets instance;
    public int randEnemy;
    public string EnemyName;
    public Text targetText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        randEnemy = Random.Range(0, enemyList.Length);
        enemyList[randEnemy].tag = "Enemy";
        EnemyName = enemyList[randEnemy].name;
        
        print(EnemyName);

        if (EnemyName == "Enemy1")
        {
           
            targetText.text = "Target: Women who is Walking";
        }
        else if (EnemyName == "Enemy2")
        {
            
            targetText.text = "Target: Man who is Running";
        }
        else if (EnemyName == "Enemy3")
        {
            
            targetText.text = "Target: Man who is Dancing";
        }
        else if (EnemyName == "Enemy4")
        {
            
            targetText.text = "Target: Women who is drunk";
        }
        else if (EnemyName == "Enemy5")
        {
           
            targetText.text = "Target: Women who is Singing";
        }
        else if (EnemyName == "Enemy6")
        {
            
            targetText.text = "Target: Man who is speaking to a girl";
        }
        else if (EnemyName == "Enemy7")
        {
            
            targetText.text = "Target: Man who is groming around with his phone";
        }
        else if (EnemyName == "Enemy8")
        {
            
            targetText.text = "Target: Woman who is working out";
        }
        else if (EnemyName == "Enemy9")
        {
            
            targetText.text = "Target: Women who is idle";
        }

    }

    // Update is called once per frame
    void Update()
    {

      

    }

    
        
}
