using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesPoint : MonoBehaviour
{
   
    void Update()
    {

        if(transform.position.y != 0.5)
        {
            Destroy(this.gameObject);
        }

    }

    /*void OnTriggerExit(Collider Other)
    {
        if(Other.tag == "Player1")
        {
          Destroy(this.gameObject);
        }

        if(Other.tag == "Player2")
        {
            Destroy(this.gameObject);
        }
        
    }*/
}
