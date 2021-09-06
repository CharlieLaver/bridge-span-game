using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class AllowDesPoint : MonoBehaviour
{

    private DateTime timeLast;
    private int delayInSeconds = 1;


    public bool AllowSpawnPoint()
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
