using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{

    public Transform SnakeHead;
    public float Diameter;

    private List<Transform> snakeBody = new List<Transform>();
    private List<Vector2> positions = new List<Vector2>();

    private void Awake()
    {
        positions.Add(SnakeHead.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = ((Vector2)SnakeHead.position - positions[0]).magnitude;

        if (distance > Diameter)
        {
            Vector2 direction = ((Vector2)SnakeHead.position - positions[0]).normalized;

            positions.Insert(0, positions[0] + direction * Diameter);
            positions.RemoveAt(positions.Count - 1);

            distance -= Diameter;
        }

        for (int i = 0; i <snakeBody.Count; i++)
        {
            snakeBody[i].position = Vector2.Lerp(positions[i + 1], positions[i], distance / Diameter);
        }
    }

    public void AddBody()
    {
        Transform body = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform);
        snakeBody.Add(body);
        positions.Add(body.position);
    }
}
