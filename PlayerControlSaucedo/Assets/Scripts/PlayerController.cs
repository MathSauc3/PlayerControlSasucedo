using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnspeed = 50;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(0, Time.deltaTime * 720, 0, Space.Self);
        if (Input.GetKey(KeyCode.Q))
        transform.Translate(0, Time.deltaTime * 50, 0, Space.Self);
        
    }
}
