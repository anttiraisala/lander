using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ArtificialNeuralNetwork;
using ArtificialNeuralNetwork.Factories;

public class ObjectController : MonoBehaviour
{
    

	public GameObject camera;
	public GameObject ground;
	public GameObject lander;

	private INeuralNetwork network;
	[SerializeField]
	private float output;

    // Use this for initialization
    void Start()
    {

		var numInputs = 2;
		var numOutputs = 1;
		var numHiddenLayers = 1;
		var numNeuronsInHiddenLayer = 5;
		network = NeuralNetworkFactory.GetInstance().Create(numInputs, numOutputs, numHiddenLayers, numNeuronsInHiddenLayer);


		camera.transform.position = new Vector3(50.0f, 3.0f, -5.0f);

        for (float z = 0; z < 10; z += 1.0f)
        {
            for (float x = 0; x < 10; x += 1.0f)
            {
                float xCenter = (float)x * 10.0f;
                float zCenter = (float)z * 10.0f;

                GameObject groundGameObject = Instantiate(ground, new Vector3(xCenter + 0, 0, zCenter+0), Quaternion.identity);
                GameObject landerGameObject = Instantiate(lander, new Vector3(xCenter + 0, Random.Range(3.0f, 100.0f), zCenter + 0), Quaternion.identity);
                Thrust thrust = landerGameObject.GetComponent<Thrust>();
                thrust.SetGround(groundGameObject.GetComponent<Transform>());
                Rigidbody landerRigidBody = landerGameObject.GetComponent<Rigidbody>();
				landerRigidBody.velocity = new Vector3(0, Random.Range(-10.0f, 30.0f), 0);
			}
        }

    }

    // Update is called once per frame
    void Update()
    {

        var inputs = new double[] { 1.4, 2.04045 };
        network.SetInputs(inputs);
        network.Process();
        var outputs = network.GetOutputs();
        output = (float)outputs[0];
    }
}
