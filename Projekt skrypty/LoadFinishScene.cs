using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class LoadFinishScene : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<PlayableDirector>().state != PlayState.Playing)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
