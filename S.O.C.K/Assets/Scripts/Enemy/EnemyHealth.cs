using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //Ammount of health for the enemy
    public float health;

    //Used in the gun script
    public static float enemyH;

    //The enemy in question
    public GameObject enemy;

    //On start, enemyH equals health set in the editor
    void Start()
    {
        enemyH = health;
    }

    // If the enemy's health is at or below zero, they will die
    void Update()
    {
        if(enemyH <= 0f)
		{
            DestroyObject(enemy);
		}
    }
}
