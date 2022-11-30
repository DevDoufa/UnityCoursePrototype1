using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 10f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        //Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //forward motion
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //turn around
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        

        
    }
}
