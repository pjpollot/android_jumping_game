using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float timer = 2;

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
            Destroy(this.gameObject);
    }
}
