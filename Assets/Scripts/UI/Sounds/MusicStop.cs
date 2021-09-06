using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStop : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("ThemeMusic").GetComponent<MusicClass>().StopMusic();
    }

   
}
