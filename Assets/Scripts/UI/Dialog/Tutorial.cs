using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    private bool continueText;

    GameObject player1;
    Player1Move player1Move;
    GameObject finishObj;
    FinishLine finishLine;


    void Start()
    {
         player1 = GameObject.FindGameObjectWithTag("Player1");
         player1Move = player1.GetComponent<Player1Move>();
         finishObj = GameObject.Find("FinishLine");
         finishLine = finishObj.GetComponent<FinishLine>();
         StartCoroutine(Type());
    }

    void Update()
    {
        if(player1Move.gameOver)
        {
            textDisplay.enabled = false;
        }

        if(finishLine.levelComplete)
        {
            textDisplay.enabled = false;
        }
    }

 

    IEnumerator Type()
    {
        
           foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        yield return new WaitForSeconds(2);
        NextSentence();
        
        
    }
    
    public void NextSentence()
    {
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
}
