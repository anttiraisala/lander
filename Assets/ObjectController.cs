using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public GameObject ground;
    public GameObject lander;

    // Use this for initialization
    void Start()
    {

        for (int z = 0; z < 10; z++)
        {
            for (int x = 0; x < 10; x++)
            {
                float xCenter = (float)x * 10.0f;
                float zCenter = (float)z * 10.0f;

                Instantiate(ground, new Vector3(xCenter + 0, 0, zCenter+0), Quaternion.identity);
                Instantiate(lander, new Vector3(xCenter + 0, Random.Range(3.0f, 30.0f), zCenter + 0), Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
