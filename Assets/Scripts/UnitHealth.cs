using UnityEngine;
using System.Collections;

public class UnitHealth : MonoBehaviour {

    private float u_health;
    private float u_maxHealth;


    void Start()
    {
        u_health = u_maxHealth;
    }
    

    public void TakeDamage(float amount)
    {
        u_health = u_health - amount;
    }

    public void RecoverHealth(float amount)
    {
        u_health = u_health + amount;
        if(u_health > u_maxHealth)
        {
            u_health = u_maxHealth;
        }
    }
}
