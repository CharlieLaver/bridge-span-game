using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{

    private GameObject player2;
    Player2Move player2Move;
	Animator player2Anim;
	UnityEngine.AI.NavMeshAgent player2Agent;

    private GameObject player1;
    Player1Move player1Move;
	Animator player1Anim;
	UnityEngine.AI.NavMeshAgent player1Agent;

    public GameObject gameOverUI;
    
    void Start()
    {
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player2Move = player2.GetComponent<Player2Move>();
		player2Anim = player2.GetComponent<Animator>();
		player2Agent = player2.GetComponent<UnityEngine.AI.NavMeshAgent>();

        player1 = GameObject.FindGameObjectWithTag("Player1");
        player1Move = player1.GetComponent<Player1Move>();
		player1Anim = player1.GetComponent<Animator>();
		player1Agent = player1.GetComponent<UnityEngine.AI.NavMeshAgent>();

        gameOverUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Projectile")
       {
           if(this.gameObject.tag == "Player1")
           {
             player1Agent.Stop();
             player1Anim.SetBool("Die", true);
             Debug.Log("PLAYER1 DEAD!!");
             player1Move.enabled = false;
             player2Move.enabled = false;
             gameOverUI.SetActive(true);
             player1Move.gameOver = true;
             player1Move.gameOverSound = true;
           }
           else if(this.gameObject.tag == "Player2")
           {
             player2Agent.Stop();
             player2Anim.SetBool("Die", true);
             Debug.Log("PLAYER2 DEAD!!");
             player1Move.enabled = false;
             player2Move.enabled = false;
             gameOverUI.SetActive(true);
           }
           
         
       }

       
    }
}
