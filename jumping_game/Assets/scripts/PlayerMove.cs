using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardForce*Time.deltaTime,0,forwardForce*Time.deltaTime);   

        if (Input.GetKey("s")) {
            forwardForce = 0;
        }
    }
}
