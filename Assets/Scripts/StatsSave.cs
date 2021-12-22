using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSave : MonoBehaviour
{
    public static int SnakeHP = 40;
    public static int Score;
    public static int HighScore;

    private void Update()
    {
        if (HighScore < Score)
            HighScore = Score;
    }
   
}
