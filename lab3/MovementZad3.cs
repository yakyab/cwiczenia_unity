using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementZad3 : MonoBehaviour
{
    [SerializeField] float speed = 1;
    float positionX = 0;
    float positionZ = 0;    

    void Update()
    {
        positionX = transform.position.x;
        positionZ = transform.position.z;

        if(positionX >= 10 && positionZ <= 0)
        {
            transform.eulerAngles = new Vector3(0f,270f,0f);
        }  
        if(positionX >= 10 && positionZ >= 10)
        {
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
        if(positionX <= 0 && positionZ >= 10)
        {
            transform.eulerAngles = new Vector3(0f,90f,0f);
        }
        if(positionX <= 0 && positionZ <= 0)
        {
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }

        transform.Translate(Time.deltaTime * speed, 0, 0);
    }
}
