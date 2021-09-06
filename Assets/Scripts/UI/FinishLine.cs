using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public bool player1Safe;
    public bool player2Safe;
    public GameObject levelCompleteUI;

    private GameObject player1;
    Player1Move player1Move; 
    public bool levelComplete;

    public AudioSource[] sounds;

    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player1Move = player1.GetComponent<Player1Move>();
        player1Safe = false;
        player2Safe = false;
        levelCompleteUI.SetActive(false);
    }

    void Update()
    {
        if(player1Move.gameOver == true)
        {
            levelCompleteUI.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.tag == "Player1")
        {
            player1Safe = true;
            Debug.Log("PLAYER1 SAFE!");
            PlaySoundAtRandom();
        }
        
        if(Other.gameObject.tag == "Player2")
        {
            player2Safe = true;
            Debug.Log("PLAYER2 SAFE!!");
            PlaySoundAtRandom();
        }

        if (player1Safe && player2Safe)
        {
            Debug.Log("LEVEL COMPLETE!!");
            levelCompleteUI.SetActive(true);
            levelComplete = true;
            PlaySoundAtRandom();
        }
    }

    void PlaySoundAtRandom()
    {
        var randomSound = sounds[Random.Range(0, sounds.Length)];
        randomSound.Play();
    }
}
