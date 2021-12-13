using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 velocity;
    Vector3 position;
    
    void Update() {

        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        position = transform.localPosition;

       if (Input.GetKey("j"))
            position.x += -velocity.x*Time.deltaTime;

       if (Input.GetKey("l"))
            position.x += velocity.x*Time.deltaTime;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),out hit, 1,layerMask)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);

            if (Input.GetKey("i"))
                    rb.AddForce(0,10,0);
        }

        position.z += velocity.z*Time.deltaTime;

       transform.localPosition = position;
    }

}
