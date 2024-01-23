using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    public int enemyHealth = 10;

    // public GameObject deathEffect;
    
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0 )
        {
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        // Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
