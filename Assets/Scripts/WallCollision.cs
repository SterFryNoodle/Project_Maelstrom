using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Changes object color after player enters object collider parameters.

public class WallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {        
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
