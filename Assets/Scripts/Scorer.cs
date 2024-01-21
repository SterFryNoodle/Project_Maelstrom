using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Increments variable after player enters another object's collider.
public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You've bumped into an object this many times: " + score);
        }
        
        
    }
}
