using UnityEngine;
using System.Collections;

public class u_DistanceTravelled : MonoBehaviour {

    private float distanceTraveled = 0f;
    private Vector3 lastPosition;

	// Use this for initialization
	void Start () {
        lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        distanceTraveled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        Debug.Log(distanceTraveled);
	}
}
