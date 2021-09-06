using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    public AudioSource[] sounds;

    void Start()
    {
        PlaySoundAtRandom();
    }
    void PlaySoundAtRandom()
    {
        var randomSound = sounds[Random.Range(0, sounds.Length)];
        randomSound.Play();
    }
    
}
