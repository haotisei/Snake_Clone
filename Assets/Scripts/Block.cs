using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class Block : MonoBehaviour
{
    public int health;
  
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
        color = (float)(health) / 50;
        Debug.Log(color);

        points.text = health.ToString();
        renderer.material.color = g.Evaluate(color);
    }

    void Update()
    {
        points.text = health.ToString();
    }

    public void BlockHit()
    {
        health--;
        Debug.Log("HP Left" + health);
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
