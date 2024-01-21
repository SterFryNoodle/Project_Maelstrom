using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enables both the Mesh Renderer and gravity of an object in inpection after amt of time has passed.
public class ObjectDropper : MonoBehaviour
{
    MeshRenderer rend;
    Rigidbody rb;
    [SerializeField] float timeThreshold = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Time passed: " + Time.time);
        if (Time.time > timeThreshold)
        {
            rend.enabled = true;
            rb.useGravity = true;
        }
        else
        {
            rb.useGravity = false;
        }
    }
}
