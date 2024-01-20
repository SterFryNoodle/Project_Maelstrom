using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {        
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
