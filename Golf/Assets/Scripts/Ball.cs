using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Variables
    float xAngle = 1.5f;
    float yAngle = 0.8f;
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

    // Returns y position of transform
    public float YPos()
    {
        return this.transform.position.y;
    }
}
