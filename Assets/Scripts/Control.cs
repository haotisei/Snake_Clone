using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public SnakeMovement Snake;

    void Update()
    {
        Snake.Move();
    }
}
