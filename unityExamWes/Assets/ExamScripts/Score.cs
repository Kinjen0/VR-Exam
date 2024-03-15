using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Hold the score total, and text
    private int score = 0;
    public Text scoreText;

    // Add an inputed amount to the score, and update it. 
    public void addScore(int i)
    {
        score += i;
        scoreText.text = "Score: " + score;

    }
}
