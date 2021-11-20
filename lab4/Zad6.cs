using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad6 : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "ContactCheck")
        {
            Debug.Log("Uderzyles w przeszkode!");
        }
    }
}
