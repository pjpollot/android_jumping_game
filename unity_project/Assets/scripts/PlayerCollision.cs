using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMove mvmt;
    
    void OnCollisionEnter(Collision colInfo) {

        if (colInfo.collider.tag == "Obstacles") {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
