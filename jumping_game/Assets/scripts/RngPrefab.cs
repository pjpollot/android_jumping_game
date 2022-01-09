using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RngPrefab : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject myPrefab1;
    public GameObject myPlayer;
    public bool here;
    float timer = 3;
    void Start()
    {
        myPlayer = GameObject.Find("Player");
        here = false;
    }

    
    void Update()
    {

        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(5.0f, 15.0f);
            Instantiate(myPrefab1, new Vector3(0, 1.5f, myPlayer.transform.position.z + 40), Quaternion.identity);
        }
            

        if ((int)myPlayer.transform.position.z % 20 == 0 & !here)
        {
            here = true;
            Debug.Log(here);
            Debug.Log("instantiate");
            // Instantiate at position (0, 0, 0) and zero rotation.
            Instantiate(myPrefab, new Vector3(Random.Range(-7.0f,7.0f), 0, myPlayer.transform.position.z + 30), Quaternion.identity);
        }

        if ((int)myPlayer.transform.position.z % 20 == 10 & here)
        {
            here = false;
        }

    }

}
