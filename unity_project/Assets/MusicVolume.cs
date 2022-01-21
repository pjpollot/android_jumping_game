using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{

    public AudioSource music;
    float volume = Volume.mvolume;

    // Update is called once per frame
    void Update()
    {
        music.volume = volume;
    }
}
