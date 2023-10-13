using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreToReach;

    private int player1score = 0;
    private int player2score = 0;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public void Player1Goal()
    {
        player1score++;
        player1ScoreText.text = player1score.ToString();
        Debug.Log("Player 1 Score: " +  player1score);
        CheckScore();
    }
    public void Player2Goal()
    {
        player2score++;
        player2ScoreText.text = player2score.ToString();
        Debug.Log("Player 2 Score: " + player2score);
        CheckScore();
    }

    private void CheckScore()
    {
        if(player1score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
}
