using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public AudioSource boom;
    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] float loadDelay = 1f;

    void OnCollisionEnter(Collision other) 
    {
        Debug.Log(this.name + " Kolizja z " + other.gameObject.name);
        explosionParticle.Play();
        boom.Play();
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<PlayerControl>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        Invoke("ReloadLevel", loadDelay);
    }
    void OnTriggerEnter(Collider other) 
    {
        Debug.Log(this.name + " Kolizja z " + other.gameObject.name);
        explosionParticle.Play();
        boom.Play();
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<PlayerControl>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        Invoke("ReloadLevel", loadDelay);
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(2);
    }

}
