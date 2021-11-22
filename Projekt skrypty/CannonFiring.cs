using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{
    public AudioSource cannonSound;
    public GameObject[] lasers;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            cannonSound.Play();
            foreach (GameObject laser in lasers)
            {
                var emissionModule = laser.GetComponent<ParticleSystem>().emission; 
                emissionModule.enabled = true;       
            }
        }
        else
        {
            foreach (GameObject laser in lasers)
            {
                var emissionModule = laser.GetComponent<ParticleSystem>().emission; 
                emissionModule.enabled = false;       
            }
        }
    }
}
