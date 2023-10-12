using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int player1score = 0;
    private int player2score = 0;

    public TextMesh player1ScoreText;
    public TextMesh player2ScoreText;

    public void Player1Goal()
    {
        player1score++;
        player1ScoreText.text = player1score.ToString();
        Debug.Log("Player 1 Score: " +  player1score);
    }
    public void Player2Goal()
    {
        player2score++;
       player2ScoreText.text = player2score.ToString();
        Debug.Log("Player 2 Score: " + player2score);
    }
}
