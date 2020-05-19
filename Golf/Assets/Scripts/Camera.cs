using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Var

    // Cache
    Ball ball;
    
    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        SetYPos();
    }

    private void SetYPos()
    {
        // Make this set the Y position based on ball.YPos()
    }
}
