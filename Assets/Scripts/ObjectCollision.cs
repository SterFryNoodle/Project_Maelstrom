using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Changes object color after player enters object collider parameters.

public class ObjectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)// collision variable passes in collider of object that had bumped 
    {                                                 // into object this script is attached to.
        if(collision.gameObject.tag == "Player") 
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            gameObject.tag = "Hit";
        }
        
    }
}
