using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    public AudioSource music;
    public Slider value;
    static public float mvolume;

    // Update is called once per frame
    void Update()
    {
        music.volume = value.value;
        mvolume = value.value;
    }
}
