using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAlreadyPlaying : MonoBehaviour
{
    private int howManyMusic;
    void Start()
    {
        howManyMusic = GameObject.FindGameObjectsWithTag("Music").Length;
          
        if(howManyMusic > 1)
        {
            Debug.Log("howmanymusic: " + howManyMusic);
            Destroy(this.gameObject);
        }
    }

}
