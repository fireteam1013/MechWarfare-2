using UnityEngine;
using System.Collections;

public class i_Armor : MonoBehaviour {

    public  float a_Defense = 15;   //Defense is subtracted from attacks when calculating damage;
    public  float a_Health;         //The health of the armor.  The total amount of damage is deducted from this health.  when it is 0, the armor is destroyed.


}
