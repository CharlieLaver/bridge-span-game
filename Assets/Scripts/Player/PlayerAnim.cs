using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private GameObject player1;
    Player1Move player1Move;
    public Animator animator;
    public bool player1ReachedDes;
    public bool player2ReachedDes;
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player1Move = player1.GetComponent<Player1Move>();
        player1ReachedDes = false;
        player2ReachedDes = false;
        
    }

    
    void Update()
    {

        if(player1ReachedDes == true)
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Move", false);
        }
        else if(player1ReachedDes == false)
        {
            animator.SetBool("Move", true);
            animator.SetBool("Idle", false);
        }

        if(player2ReachedDes == true)
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Move", false);
        }
        else if(player2ReachedDes == false)
        {
            animator.SetBool("Move", true);
            animator.SetBool("Idle", false);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "DesPoint")
        {
           Debug.Log("PLAYER1 REACHED DES!");
           player1ReachedDes = true;
        }

        if(other.tag == "DesPoint")
        {
           Debug.Log("PLAYER2 REACHED DES!");
           player2ReachedDes = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "DesPoint")
        {
            player1ReachedDes = false;
        }

        if(other.tag == "DesPoint")
        {
            player2ReachedDes = false;
        }
    }

   
}
