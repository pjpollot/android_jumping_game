using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMove mvmt;
    
    void OnCollisionEnter(Collision colInfo) {

        if (colInfo.collider.tag == "Obstacles") {
            Debug.Log("We hit something.");
            mvmt.enabled = false;
        }
    }
}
