using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] AudioSource boom;
    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] int enemyHitScore = 10;
    [SerializeField] int enemyKillScore = 100;
    [SerializeField] int enemyHitPoints = 3;
    Score scoreBoard;
    void Start() 
    {
        scoreBoard = FindObjectOfType<Score>();
    }
    void OnParticleCollision(GameObject other) 
    {
        scoreBoard.IncreaseScore(enemyHitScore);
        explosionParticle.Play();
        enemyHitPoints--;
        if(enemyHitPoints < 1)
        {
            scoreBoard.IncreaseScore(enemyKillScore);
            Destroy(gameObject);
            boom.Play();
        }
    }
}
