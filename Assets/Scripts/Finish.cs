using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Game Game;
    public SnakeMovement Snake;
    private void OnCollisionEnter(Collision collision)
    
        {
        PlayerPrefs.SetInt("SnakeHP", Snake.Length);
        
        Game.GameWon();


        
        Debug.Log("Player Entered");

    }
}
