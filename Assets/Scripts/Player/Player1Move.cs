using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player1Move : MonoBehaviour
{
    NavMeshAgent agent;
    private GameObject player2;
    Player2Move player2Move;
    PlayerAnim player2Anim;

    private GameObject player1;
    Player1Move player1Move;
    public int numOfMoves = 6;

    private GameObject finishPoint;
    FinishLine finishLine;
    public GameObject gameOverUI;

    public GameObject destinationObj;
    public Camera mainCamera;

    private GameObject playerManager;
    AllowDesPoint allowDesPoint;

    private GameObject soundObj;
    AudioSource sound;

    public bool gameOver;
    public bool gameOverSound;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player2Move = player2.GetComponent<Player2Move>();
        player2Anim = player2.GetComponent<PlayerAnim>();
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player1Move = player1.GetComponent<Player1Move>();
        finishPoint = GameObject.Find("FinishLine");
        finishLine = finishPoint.GetComponent<FinishLine>();
        playerManager = GameObject.Find("Player");
        allowDesPoint = playerManager.GetComponent<AllowDesPoint>();
        soundObj = GameObject.Find("DesPointSound");
        sound = soundObj.GetComponent<AudioSource>();

        gameOverUI.SetActive(false);
        player2Move.enabled = false;
    }

    void Update()
    {
        if(player2Anim.player2ReachedDes)
        {
           if (finishLine.player1Safe)
        {
            player2Move.enabled = true;
            player1Move.enabled = false;
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
        {
            if(numOfMoves <= 0)
            {
                Debug.Log("N0 MORE MOVES!!");
                gameOverUI.SetActive(true);
                gameOver = true;
                gameOverSound = true;
            }
            else
            {
            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
              if(allowDesPoint.AllowSpawnPoint())
              {
                agent.SetDestination(hit.point);
                Instantiate(destinationObj, hit.point, Quaternion.identity);
                numOfMoves = numOfMoves - 1;
                player2Move.enabled = true;
                player1Move.enabled = false;
                sound.Play();
              }
              
            }

            
            }
            
            
        }
        }
        }
  
       
    }


}
