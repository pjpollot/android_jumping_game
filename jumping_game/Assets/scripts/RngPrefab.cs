using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RngPrefab : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public GameObject myPrefab1;
    public GameObject ground;
    public GameObject myPlayer;
    public bool diffcheck;

    int diffnum = 1;
    int numGroundSpawned = 0;
    float timer = 3;
    float timer2 = 2;
    void Start()
    {
        myPlayer = GameObject.Find("Player");
        diffcheck = false;
    }

    
    void Update()
    {

        timer -= 1 * Time.deltaTime;
        timer2 -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(5.0f, 10.0f);
            Instantiate(myPrefab1, new Vector3(0, 1.0f, myPlayer.transform.position.z + 20), Quaternion.identity);
        }
            

        if (timer2 <= 0)
        {
            timer2 = 4f;

            for (int i = 1; i <= diffnum; i++)
            {
                Instantiate(myPrefab, new Vector3(Random.Range(-8.5f, 1.1f), 0, myPlayer.transform.position.z + (90/(1+diffnum)) + (90 * i / (1 + diffnum))), Quaternion.identity);
            }

        }

        if ((int)myPlayer.transform.position.z % 200 == 0 & !diffcheck)
        {
            diffcheck = true;
            diffnum += 1;
        }

        if ((int)myPlayer.transform.position.z % 200 == 100 & diffcheck)
        {
            diffcheck = false;
        }


        if ((int)myPlayer.transform.position.z % 9000 == 0)
        {
            Instantiate(ground, new Vector3(0, 0, 15000 + 10000*numGroundSpawned), Quaternion.identity);
            numGroundSpawned += 1;
        }

    }

}
