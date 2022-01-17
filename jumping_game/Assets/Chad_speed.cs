using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chad_speed : MonoBehaviour
{

    public Rigidbody rb;
    Vector3 velocity;
    float speedZ;
    // Start is called before the first frame update
    void Start()
    {
        speedZ = 100;
    }

    // Update is called once per frame
    void Update()
    {
            velocity.z = speedZ;
            rb.velocity = velocity;
    }
}
