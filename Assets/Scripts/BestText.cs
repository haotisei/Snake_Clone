using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestText : MonoBehaviour
{
    public Text text; 
    void Start()
    {
        text.text = "BEST" + StatsSave.HighScore.ToString();
    }

}
