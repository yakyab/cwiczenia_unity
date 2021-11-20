using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{
    public float speed = 2f;
    bool isRunning = false;
    bool isRunningTowards = false;
    bool isRunningBack = false;
    Transform oldParent;
    public GameObject[] waypoints;
    //waypointy są pustymi gameobjectami, które przekazują współrzędne
    //waypointem o indeksie 0 powinna być płyta
    int current = 0;
    float WPradius = 1;
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void FixedUpdate()
    {
        if(isRunning == true || isRunningTowards == true || isRunningBack == true)
        {   
            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                if(isRunningTowards == true)
                {
                    current++;
                    if(current >= waypoints.Length)
                    {
                        isRunningBack = true;
                        isRunningTowards = false;
                        current--;
                    }
                }
                else if (isRunningBack == true)
                {
                    
                    if(current > 0)
                    {
                        current--;
                    }
                    else if (current == 0)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime * speed);
                    }
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            Debug.Log(current);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszedł na windę.");
            oldParent = other.gameObject.transform.parent;
            other.gameObject.transform.parent = transform;
            isRunning = true;
            isRunningTowards = true;
            isRunningBack = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszedł z windy.");
            other.gameObject.transform.parent = oldParent;
            isRunning = false;
        }
    }
}
