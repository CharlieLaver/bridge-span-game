using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOverSound : MonoBehaviour
{
    public AudioSource[] sounds;

    GameObject player1;
    Player1Move player1Move;

     private DateTime timeLast;
     private int delayInSeconds = 10;

    void Start()
    {
        player1 = GameObject.Find("Player1");
        player1Move = player1.GetComponent<Player1Move>();
    }

    void Update()
    {
      if(player1Move.gameOverSound)
      {
          player1Move.gameOverSound = false;
          if(Allow())
          {
            PlaySoundAtRandom();
          }
          
      }
      
     
    }
    void PlaySoundAtRandom()
    {
        var randomSound = sounds[UnityEngine.Random.Range(0, sounds.Length)];
        randomSound.Play();
    }

    public bool Allow()
    {
        DateTime time = DateTime.Now;
        TimeSpan ts = time - timeLast; 
        if (ts.TotalSeconds > delayInSeconds)
        {
            timeLast = time;
            return true;
        } 
        return false;
    }

}
