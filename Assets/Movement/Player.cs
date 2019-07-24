﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        float velThisFrame = moveSpeed;

        if (Input.GetButton("Horizontal") && Input.GetButton("Vertical")) {
            velThisFrame *= 0.707f;
        }

        GetComponentInChildren<Rigidbody2D>().velocity = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
        ) * velThisFrame;
    }
}
