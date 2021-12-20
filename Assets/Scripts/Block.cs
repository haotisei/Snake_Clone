using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class Block : MonoBehaviour
{
    int health;
  
    public int minHP;
    public int maxHP;
    public Renderer renderer;
    float color;

    public Gradient g;
    GradientColorKey[] gck;
    GradientAlphaKey[] gak;

    public TMP_Text points;

    void Awake()
    {
        health = Random.Range(minHP, maxHP + 1);
        renderer = GetComponent<Renderer>();
    }

    void Start()
    {
         /*g = new Gradient();
        gck = new GradientColorKey[2];
        gck[0].color = Color.red;
        gck[0].time = 0.0f;
        gck[1].color = Color.black;
        gck[1].time = 1.0f;

        gak = new GradientAlphaKey[2];
        gak[0].alpha = 1.0f;
        gak[0].time = 1.0f;
        gak[1].alpha = 1.0f;
        gak[1].time = 1.0f;

        g.SetKeys(gck, gak);
         */

        color = (float)(health) / 50;
        Debug.Log(color);

        points.text = health.ToString();
        renderer.material.color = g.Evaluate(color);
    }

    IEnumerator Hit()
    {
        health--;
        points.text = health.ToString();
        Debug.Log("HP Left" + health);
        yield return new WaitForSeconds(3f);
       
        
    }

  private void OnCollisionStay(Collision collision)
    {
        StartCoroutine(Hit());
        if (health <= 0)
        { StopCoroutine(Hit());
        this.gameObject.SetActive(false); }
    }
}
