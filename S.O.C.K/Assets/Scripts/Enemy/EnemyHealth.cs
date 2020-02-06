using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //Ammount of health for the enemy
    public float health;

    public static float enemyH;

    public GameObject enemy;
    
    void Start()
    {
        enemyH = health;
    }

    
    void Update()
    {
        if(enemyH <= 0f)
		{
            DestroyObject(enemy);
		}
    }
}
