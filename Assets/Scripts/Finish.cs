using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Game Game;
    public GameObject MenuScreen;
    public GameObject PlayScreen;
    private void OnCollisionEnter(Collision collision)
    
        {
        
        
        Game.GameWon();
        PlayScreen.SetActive(false);
        MenuScreen.SetActive(true);

        
        Debug.Log("Player Entered");

    }
}
