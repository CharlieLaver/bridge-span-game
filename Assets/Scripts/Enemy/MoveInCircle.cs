using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInCircle : MonoBehaviour
{
    
    float timeCounter = 0;

    public float speed;
    public float height;
    public float width;


    void Update()
    {
        timeCounter +=  Time.deltaTime * speed;

        float x = Mathf.Cos (timeCounter) * width;
        float y = 0;
        float z =  Mathf.Sin (timeCounter)* height;

        transform.position = new Vector3 (x, y, z);
    }
}
