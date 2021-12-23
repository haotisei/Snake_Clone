using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    int FoodPoint;
    public TextMeshPro Point;
    public AudioSource Sound;

    void Start()
    {
        FoodPoint = Random.Range(1, 6);
        Sound = Instantiate(Sound);
    }

    // Update is called once per frame
    void Update()
    {
        Point.text = FoodPoint.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out SnakeMovement Snake))
        {
            StatsSave.SnakeHP += FoodPoint;
            Sound.Play();
            this.gameObject.SetActive(false);
        }
    }
}
