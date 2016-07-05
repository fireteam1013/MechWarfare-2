using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    GameObject cam;

    void Awake()
    {
        cam = GameObject.Find("Main Camera");
    }
}
