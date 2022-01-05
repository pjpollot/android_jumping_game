using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RngPrefab : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject myPlayer;
    public bool here;
    void Start()
    {
        myPlayer = GameObject.Find("Player");
        here = false;
    }

    
    void Update()
    {


        if ((int)myPlayer.transform.position.z % 20 == 0 & !here)
        {
            here = true;
            Debug.Log(here);
            Debug.Log("instantiate");
            // Instantiate at position (0, 0, 0) and zero rotation.
            Instantiate(myPrefab, new Vector3(Random.Range(-7.0f,7.0f), 0, myPlayer.transform.position.z + 20), Quaternion.identity);
        }

        if ((int)myPlayer.transform.position.z % 20 == 10 & here)
        {
            here = false;
        }

    }

}
