using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score;
    TMP_Text scoreText;
    void Start() 
    {
        score = 0;
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Score: 0";
    }
    public void IncreaseScore(int amount)
    {
        score = score + amount;
        scoreText.text = "Score: " + score.ToString();
    }
}
