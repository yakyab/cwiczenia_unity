using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementZad2 : MonoBehaviour
{
    [SerializeField] float speed = 1;
    float direction = 1;
    void Update()
    {
        if(transform.position.x >= 10)
        { 
            direction = -1;
        }
        else if(transform.position.x <= 0)
        {    
            direction = 1;
        }
        transform.Translate(speed*Time.deltaTime*direction, 0, 0);
    }
}
