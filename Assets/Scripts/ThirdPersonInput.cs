using UnityEngine;
using System.Collections;

public class ThirdPersonInput : MonoBehaviour {

    private PlayerMovement p_Movement;
    private Transform p_Cam;
    private Vector3 p_CamForward;
    private Vector3 p_Move;
    private bool p_Jump;


    private void Start()
    {
        p_Movement = GetComponent<PlayerMovement>();
    }
}
