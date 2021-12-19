using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Game Game;
    private void OnCollisionEnter(Collision collision)
    
        {
        Game.GameWon();


        
        Debug.Log("Player Entered");

    }
}
