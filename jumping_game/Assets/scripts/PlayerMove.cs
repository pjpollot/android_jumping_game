using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 velocity;
    Vector3 position;
    
    void Update() {
        position = transform.localPosition;

       if (Input.GetKey("j"))
            position.x += -velocity.x*Time.deltaTime;

       if (Input.GetKey("l"))
            position.x += velocity.x*Time.deltaTime;
        
        if (Input.GetKey("k"))
            position.y += velocity.y*Time.deltaTime;

       position.z += velocity.z*Time.deltaTime;

       transform.localPosition = position;
    }

}
