using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    private int player1score = 0;
    private int player2score = 0;

    public Text player1ScoreText;
    public Text player2ScoreText;

    public void Player1Goal()
    {
        player1score++;
        player1ScoreText.text = player1score.ToString();
    }
    public void Player2Goal()
    {
        player2score++;
        player2ScoreText.text = player2score.ToString();
    }
}
