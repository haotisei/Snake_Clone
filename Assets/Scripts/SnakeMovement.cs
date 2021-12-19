using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float Speed;
    public Rigidbody componentRigidbody;


    private void Update()
    {

        Move();
    }


    
     private void FixedUpdate()
    {
   
       
    }
   

    public void ReachFinish()
    {
        componentRigidbody.velocity = Vector3.zero;
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

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
    
