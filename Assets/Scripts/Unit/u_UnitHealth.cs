using UnityEngine;
using System.Collections;

public class u_UnitHealth : MonoBehaviour {

    public float health;
    float maxHealth = 100f;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        health = health - amount;
        Debug.Log(health);
    }
}
