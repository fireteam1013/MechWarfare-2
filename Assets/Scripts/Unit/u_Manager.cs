using UnityEngine;
using System.Collections;

public class u_Manager : MonoBehaviour {

    int level;
    int healthMod;

    float health;
    float maxHealth;

    

    void TakeDamage(float amount)
    {
        health = health - amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void RecoverHealth(float amount)
    {
        health = health + amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    void Die()
    {

    }
}
