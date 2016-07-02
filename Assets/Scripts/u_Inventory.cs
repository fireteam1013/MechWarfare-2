using UnityEngine;
using System.Collections;

public class u_Inventory : MonoBehaviour {

    public GameObject u_Armor;

    float a_Defense;
    float a_Health;

    void Start()
    {
        a_Defense = u_Armor.GetComponent<i_Armor>().a_Defense;
        a_Health = u_Armor.GetComponent<i_Armor>().a_Health;
    }


    public void Calc_Damage(float amount)
    {
        float damage = amount - a_Defense;
        a_Health = a_Health - amount;
        if (damage < 0)
        {
            damage = 0;
        }
        gameObject.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
    }
}
