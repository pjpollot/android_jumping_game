using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    Vector3 velocity;
    Vector3 accelerometerDat;
    float dirX;
    float diry;

    public float speedZ;
    public float speedX;
    public float jumpThresold;
    public float accelerationY;
    Vector3 position;

    void Start()
    {
        speedZ =  35;
    }

    void Update() {

        int layerMask = 1 << 8;
        layerMask = ~layerMask;

        accelerometerDat = Vector3.Normalize(Input.acceleration);
        dirX = accelerometerDat.x;
        diry = -accelerometerDat.y;

        velocity = rb.velocity;
        velocity.x = dirX * speedX * Time.deltaTime;
        velocity.z = speedZ;
        rb.velocity = velocity;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),out hit, 1,layerMask)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            if (diry > jumpThresold) {
                rb.AddForce(0f, accelerationY * Time.deltaTime, 0f);
            }
        }

        //position.z += velocity.z*Time.deltaTime;

       //transform.localPosition = position;
    }

}
