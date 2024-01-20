using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    private int timeThreshold = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time passed: " + Time.time);
        if (Time.time > timeThreshold)
        {
            // implement gravity to attached object.
        }
        else
        {
            // dont apply gravity.
        }
    }
}
