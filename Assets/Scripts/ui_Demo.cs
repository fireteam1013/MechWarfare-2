using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ui_Demo : MonoBehaviour {

    public Text health;
    public Text armor;

    public GameObject player;
    u_UnitHealth unitHealth;
    u_Inventory unitInventory;

    void Start()
    {
        unitHealth = player.GetComponent<u_UnitHealth>();
        unitInventory = player.GetComponent<u_Inventory>();
    }

    void Update()
    {
        health.text = unitHealth.health.ToString();
        armor.text = unitInventory.a_Health.ToString();
    }

}
