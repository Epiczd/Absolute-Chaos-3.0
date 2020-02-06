using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //Ammount of damage dealt when shooting
    private float damage = 1f;

    //Ammount of time in between each shot
    private float invincibilityTime = 0f;

    /* If the player presses the left mouse button,
     * they will fire a shot, later it will fire a bullet,
     * but for now it deals one damage, and adds some invicibility time,
     * so that way the enemy doesn't die instantly
     */
    void Update()
    {
        Debug.Log(EnemyHealth.enemyH);
        if (Input.GetMouseButtonDown(0) && invincibilityTime <= 0f)
        {
            EnemyHealth.enemyH--;
            invincibilityTime++;
        }
        else if (invincibilityTime > 0f)
        {
            invincibilityTime -= Time.deltaTime * 3f;
        }
    }
}
