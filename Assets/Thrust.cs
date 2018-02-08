using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

    [SerializeField]
    private bool simulationRunning;

	[SerializeField]
	private float motorPower;
	[SerializeField]
	private float thrust;
	[SerializeField]
	private Rigidbody rb;

    public Transform ground;

    [SerializeField]
	private Vector3 previousPosition;
	[SerializeField]
	private float speed;
	[SerializeField]
	private float height;

	[SerializeField]
	private float landingSpeed;
	[SerializeField]
	private float collisionRelativeVelocity;
	[SerializeField]
	private bool hasLanded;

    [SerializeField]
    private float fitness;



	private float startX, startZ;

	//private Transform transform;

	void Start()
	{
        motorPower = 20.0f;
		rb = GetComponent<Rigidbody>();
        startX = transform.position.x;
        startZ = transform.position.z;

        simulationRunning = true;
        hasLanded = false;
        fitness = float.NegativeInfinity;

		Debug.Log("alkaa");

	}

	void FixedUpdate()
	{
        if(!simulationRunning){
            return;
        }

        Vector3 currentPosition = new Vector3(startX, transform.position.y, startZ);
        transform.position = currentPosition;
		transform.rotation = Quaternion.identity;

        // Calculate height
        if (ground != null)
        {
            height = (currentPosition.y - 0.5f) - (ground.position.y + 0.5f);
        }

        // Calculate speed
        if(previousPosition!=null){
            Vector3 speedVector = currentPosition - previousPosition;
            speed = speedVector.magnitude / Time.fixedDeltaTime;
        }
        previousPosition = currentPosition;

        thrust = 0.0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            thrust = 1.0f;
        }

        if (thrust > 0.0f)
        {
            rb.AddForce(transform.up * motorPower * thrust);
        }


		// Should simulation stop?
		if (currentPosition.y <= -1.0f)
		{
            Destroy(rb);
			StopSimulation();
		}
		if (currentPosition.y >= 200.0f)
		{
			Destroy(rb);
			StopSimulation();
		}
	}

    void StopSimulation(){
        simulationRunning = false;

        if(hasLanded==true)
        {
            fitness = 1.0f / landingSpeed;
        }
    }

	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
        Debug.Log("collision");

        landingSpeed = speed;
		foreach (ContactPoint contact in collision.contacts)
		{
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
        if (collision.relativeVelocity.magnitude > 2)
        {
            
        }
        collisionRelativeVelocity = collision.relativeVelocity.magnitude;
        hasLanded = true;

        StopSimulation();
	}
}
