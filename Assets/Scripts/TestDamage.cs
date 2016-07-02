using UnityEngine;
using System.Collections;

public class TestDamage : MonoBehaviour {

    private float attack = 50f;
    public GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            target.SendMessage("Calc_Damage", attack, SendMessageOptions.DontRequireReceiver);
            
        }
    }
}
