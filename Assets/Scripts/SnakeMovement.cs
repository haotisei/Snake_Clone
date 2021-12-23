using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SnakeMovement : MonoBehaviour
{
    public float Speed;
    public Rigidbody componentRigidbody;
    public int Length;
    public TextMeshPro SnakeHP;
    private Block Block;
    public GameObject PlayScreen;
    public GameObject LoseScreen;
    public AudioSource Sound;
    

    public Game Game;

    void Start()
    {
        componentRigidbody = GetComponent<Rigidbody>();
        Sound = Instantiate(Sound);
    }

    void Update()
    {
        Length = StatsSave.SnakeHP;
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
        StatsSave.SnakeHP--;
        Sound.Play();
        Debug.Log("Player HP" + Length);

        if (Length <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
        StatsSave.Score = 0;
        PlayScreen.SetActive(false);
        LoseScreen.SetActive(true);
      
    }

    
}
    
