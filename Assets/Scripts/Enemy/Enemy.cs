using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    //rotate
    public float speed;
    private float waitTime;
    public float StartWaitTime;
    public float rotateSpeed;

    //move
    public Transform[] moveSpots;
    private int randomSpot;
    public Animator animator;
    private Transform currentMoveSpot;

    //shoot
    public GameObject projectile;
    public Transform shootFrom;
     private DateTime timeLast;
    public int delayInSeconds = 2;

    private GameObject player1;
    private Transform player1Pos;
    Player1Move player1Move;
    PlayerAnim player1Anim;

    private GameObject player2;
    private Transform player2Pos;
    Player2Move player2Move;
    PlayerAnim player2Anim;

    public bool patrol;
    public bool rotate; 
    public bool follow;
    public bool shoot;
    
    void Start()
    {
        waitTime = StartWaitTime;
        randomSpot = UnityEngine.Random.Range(0, moveSpots.Length);

        player1 = GameObject.FindGameObjectWithTag("Player1");
        player1Pos = player1.GetComponent<Transform>();
        player1Move = player1.GetComponent<Player1Move>();
        player1Anim = player1.GetComponent<PlayerAnim>();

        player2 = GameObject.FindGameObjectWithTag("Player2");
        player2Pos = player2.GetComponent<Transform>();
        player2Move = player2.GetComponent<Player2Move>();
        player2Anim = player2.GetComponent<PlayerAnim>();
    }

    void Update()
    {
        if(patrol)
        {
          EnemyPatrol();
        }

        if(rotate)
        {
            EnemyRotate();
        }

        if(follow)
        {
            EnemyFollow();
        }

        if(shoot)
        {
            EnemyShoot();
        }
        
    }

    void EnemyPatrol()
    {
        animator.SetBool("Move", true);

        currentMoveSpot = moveSpots[randomSpot];
        var q = Quaternion.LookRotation(currentMoveSpot.position - transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotateSpeed * Time.deltaTime);
        
        
        transform.position = Vector3.MoveTowards(transform.position, currentMoveSpot.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
        if(waitTime <= 0)
        {
            randomSpot = UnityEngine.Random.Range(0, moveSpots.Length);
            waitTime = StartWaitTime;
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
        }
    }

    void EnemyRotate()
    {
       animator.SetBool("Idle", true);
       transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    void EnemyFollow()
    {
        animator.SetBool("Idle", true);
        if(player1Anim.player1ReachedDes == false)
        {
            if(Vector3.Distance(transform.position, player1Pos.position) > 3)
            {
            animator.SetBool("Move", true);
            var q = Quaternion.LookRotation(player1Pos.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotateSpeed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player1Pos.position, speed * Time.deltaTime);
            }
        }
        else if(player2Anim.player2ReachedDes == false)
        {
            if(Vector3.Distance(transform.position, player2Pos.position) > 3)
            {
            animator.SetBool("Move", true);
            var q = Quaternion.LookRotation(player2Pos.position - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotateSpeed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player2Pos.position, speed * Time.deltaTime);
            }
        }

        if(player2Anim.player2ReachedDes && player1Anim.player1ReachedDes == true)
        {
            animator.SetBool("Move", false);
            animator.SetBool("Idle", true);
        }
        
      
    }

    void EnemyShoot()
    {
    animator.SetBool("Attack", false);
    animator.SetBool("Idle", true);

    bool AllowShoot()
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

    if(AllowShoot())
    {
        animator.SetBool("Idle", false);
        animator.SetBool("Attack", true);
        Instantiate(projectile, shootFrom.position, Quaternion.identity);
    }

    }
}
