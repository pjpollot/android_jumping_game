using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float speedX;
    Vector3 velocity;
    Vector3 accPos;
    float teta;
    float tetaPrevious;
    float speedZ;

    public float jumpThresold;
    public float accelerationY;
    Vector3 position;

    void Start()
    {
        speedZ = 35;
        accPos = Input.acceleration;
        if (accPos.z != 0)
            tetaPrevious = Mathf.Atan(accPos.y / accPos.z);
        else
            tetaPrevious = 0;

    }

    public void Pause()
    {
        velocity.x = 0;
        velocity.y = 0;
        velocity.z = 0;
        rb.velocity = velocity;

    }

    public void ReStart()
    {
        speedZ = 35;
        accPos = Input.acceleration;
        if (accPos.z != 0)
            tetaPrevious = Mathf.Atan(accPos.y / accPos.z);
        else
            tetaPrevious = 0;
    }

    void Update() {



        accPos = Input.acceleration;

        if (accPos.z != 0)
            teta = Mathf.Atan(accPos.y / accPos.z);
        else
            teta = 0;

        velocity = rb.velocity;
        velocity.x = accPos.x * speedX * Time.deltaTime;
        velocity.z = speedZ;
        rb.velocity = velocity;



        RaycastHit hit;
        if (rb.position.y < 1f & rb.position.x < 7.5 & rb.position.x > -7.5) {
            if ((teta - tetaPrevious)/Time.deltaTime > jumpThresold*Mathf.PI/180) {
                rb.AddForce(0f, (teta - tetaPrevious)/Time.deltaTime*10, 0f);
            }
        }

        if (rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        //position.z += velocity.z*Time.deltaTime;

        //transform.localPosition = position;
        tetaPrevious = teta;
    }

}
