using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal"), yValue = 0, zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, yValue, zValue);
    }
}
