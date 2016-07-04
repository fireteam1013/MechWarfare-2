using UnityEngine;
using System.Collections;

public class i_Armor : MonoBehaviour {

    private string a_Name = "Ballistic Armor";
    private string a_Description = "A simple weave of bullet resistant material with some thin metal plating.";
    private float a_Defense = 15f;   //Defense is subtracted from attacks when calculating damage;
    private float a_Health = 200f;   //The health of the armor.  The total amount of damage is deducted from this health.  when it is 0, the armor is destroyed.

    public string A_Name
    {
        get { return a_Name; }
        set { a_Name = value; }
    }
    public string A_Description
    {
        get { return a_Description; }
        set { a_Description = value; }
    }
    public float A_Defense
    {
        get { return a_Defense; }
        set { a_Defense = value; }
    }
    public float A_Health
    {
        get { return a_Health; }
        set { a_Health = value; }
    }

    void Update()
    {
        if(a_Health <= 0)
        {
            a_Defense = 0f;
        }
    }
}
