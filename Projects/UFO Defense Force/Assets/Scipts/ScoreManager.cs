using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // score to keep track of
    public TextMeshProUGUI scoreText; // Score text to be displayed

    public void IncreaseScore(int amount) // Increases score when you kill an enemy
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //Decreases score 
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Updates Score Text
    {
        scoreText.text = "Score: "+ score;
    }
}
