using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSave : MonoBehaviour
{
    public static int SnakeHP = 40;

    public void AddHP()
    {
        SnakeHP++;
    }
}
