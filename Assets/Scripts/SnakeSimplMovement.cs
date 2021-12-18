using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSimplMovement : MonoBehaviour
{
    public float Speed = 2;

    private Rigidbody componentRigidbody;

    void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.velocity = Vector2.left * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.velocity = Vector2.right * Speed;
        }
    }
}
