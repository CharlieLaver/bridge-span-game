using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovesUI : MonoBehaviour
{
    public GameObject movesUI;
    private GameObject player1;
    Player1Move player1Move;
    void Start()
    {
      player1 = GameObject.FindGameObjectWithTag("Player1");
      player1Move = player1.GetComponent<Player1Move>();
    }

    void Update()
    {
      movesUI.GetComponent<TextMeshProUGUI>().text = "" + player1Move.numOfMoves;
    }
}
