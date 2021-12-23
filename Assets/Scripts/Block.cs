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
        if (StatsSave.HighScore < StatsSave.Score)
            StatsSave.HighScore = StatsSave.Score;
    }

    public void BlockHit()
    {
        health--;
        
        StatsSave.Score++;
        Debug.Log("HP Left" + health);
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

}
