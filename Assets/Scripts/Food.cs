using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    int FoodPoint;
    public TextMeshPro Point;

    // Start is called before the first frame update
    void Start()
    {
        FoodPoint = Random.Range(1, 6);
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
            this.gameObject.SetActive(false);
        }
    }
}
