using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player2Move : MonoBehaviour
{
    NavMeshAgent agent;
    private GameObject player1;
    Player1Move player1Move;
    PlayerAnim player1Anim;

    private GameObject player2;
    Player2Move player2Move;

    private GameObject finishPoint;
    FinishLine finishLine;
    public GameObject gameOverUI;

    public GameObject destinationObj;
    public Camera mainCamera;

    private GameObject playerManager;
    AllowDesPoint allowDesPoint;

    private GameObject soundObj;
    AudioSource sound;

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player1Move = player1.GetComponent<Player1Move>();
        player1Anim = player1.GetComponent<PlayerAnim>();
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player2Move = player2.GetComponent<Player2Move>();
        finishPoint = GameObject.Find("FinishLine");
        finishLine = finishPoint.GetComponent<FinishLine>();
        playerManager = GameObject.Find("Player");
        allowDesPoint = playerManager.GetComponent<AllowDesPoint>();
        soundObj = GameObject.Find("DesPointSound");
        sound = soundObj.GetComponent<AudioSource>();

        gameOverUI.SetActive(false);
    }

    void Update()
    {
        if(player1Anim.player1ReachedDes)
        {
           if (finishLine.player2Safe)
        {
            player2Move.enabled = false;
            player1Move.enabled = true;
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
        {
            if(player1Move.numOfMoves <= 0)
            {
                Debug.Log("N0 MORE MOVES!!");
                gameOverUI.SetActive(true);
                player1Move.gameOver = true;
                player1Move.gameOverSound = true;
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
                   player1Move.numOfMoves = player1Move.numOfMoves - 1;
                   player2Move.enabled = false;
                   player1Move.enabled = true;
                   sound.Play();
                }
              
            }

            
            }
            
            
        }
        }
        }
        
        
    }


}
