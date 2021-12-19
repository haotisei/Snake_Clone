using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    int health = 10;

    void Start()
    {
       
    }

    private void Hit()
    {
        health--;

        if(health <= 0){ this.gameObject.SetActive(false); }
    }

  private void OnCollisionStay(Collision collision)
    {
        Hit();
        Debug.Log("Hit Block");
    }
}
