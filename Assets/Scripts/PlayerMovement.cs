using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows for player movement control based on how long each frame takes to execute, NOT by frame per second.

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();

    }

    void PlayerControls()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, yValue = 0, zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
