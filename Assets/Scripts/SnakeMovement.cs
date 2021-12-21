using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SnakeMovement : MonoBehaviour
{
    public float Speed;
    public Rigidbody componentRigidbody;
    private int Length = 4;
    public TextMeshPro SnakeHP;

    void Update()
    {
        SnakeHP.text = Length.ToString();
        
    }
    private void FixedUpdate()
    {
        Move();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.velocity = Vector2.left * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.velocity = Vector2.right * Speed;
        }
    }

    public void ReachFinish()
    {
        componentRigidbody.velocity = Vector3.zero;
    }

    public void Move()
    {
        if (Game.gameState == Game.GameState.Playing)
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        else
        {
            componentRigidbody.velocity = Vector3.zero;
        }
    }
}
    
