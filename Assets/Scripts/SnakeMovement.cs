using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SnakeMovement : MonoBehaviour
{
    public float Speed;
    public Rigidbody componentRigidbody;
    public int Length = 4;
    public TextMeshPro SnakeHP;
    private Block Block;
    private SnakeTail snakeTail;

    public Game Game;

    void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
        snakeTail = GetComponent<SnakeTail>();

       // for (int i = 0; i < Length; i++) SnakeTail.AddBody();
    }

    void Update()
    {
        SnakeHP.text = Length.ToString();

        Move();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.velocity = Vector2.left * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.velocity = Vector2.right * Speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Length++;
            snakeTail.AddBody();
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

    public void SnakeHit()
    {
        Length--;
        Debug.Log("Player HP" + Length);

        if (Length <= 0)
        {
            Die();
        }
    }


    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Block Block))
        {
          
            Block.BlockHit();
            SnakeHit();
            if (Block.health <= 0)
            {
                Block.gameObject.SetActive(false);
            }
        }
    
    }

    public void Die()
    {
        gameObject.SetActive(false);

        //Game.GameLost();
    }

    
}
    
