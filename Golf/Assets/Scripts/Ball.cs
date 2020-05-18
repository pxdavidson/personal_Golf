using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Variables
    float xAngle = 1f;
    float yAngle = 0f;
    float zAngle = 0f;

    // Cache
    [SerializeField] float thrust = 1.0f;
    Rigidbody ballRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.AddForce(transform.TransformVector(xAngle,yAngle,zAngle) * thrust);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
