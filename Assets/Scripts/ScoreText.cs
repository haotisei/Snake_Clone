using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = StatsSave.Score.ToString();
    }
}
