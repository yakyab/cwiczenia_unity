using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrashFinishScore : MonoBehaviour
{
    int finalScore;
    TMP_Text scoreText;
    void Update() 
    {
        finalScore = Score.score;
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Score: " + finalScore.ToString();
    }
}
