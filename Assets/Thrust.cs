using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

    [SerializeField]
    private float thrust;
    [SerializeField]
	private Rigidbody rb;

    [SerializeField]
	private Vector3 previousPosition;
    [SerializeField]
	private float speed;

    //private Transform transform;

	void Start()
	{
        thrust = 20.0f;
		rb = GetComponent<Rigidbody>();

	}

	void FixedUpdate()
	{
        Vector3 currentPosition = new Vector3(0, transform.position.y, 0);
        transform.position = currentPosition;
		transform.rotation = Quaternion.identity;

        // Calculate speed
        if(previousPosition!=null){
            Vector3 speedVector = currentPosition - previousPosition;
            speed = speedVector.magnitude;
        }
        previousPosition = currentPosition;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * thrust);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
