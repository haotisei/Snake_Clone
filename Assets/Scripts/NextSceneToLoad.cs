using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneToLoad : MonoBehaviour
{
    private int nextSceneToLoad;
    public GameObject ScreenWin;
    public GameObject ScreenPlay;
    public Game Game;

    void Start()
    {
        //nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;    
    }

  private void OnCollisionEnter(Collision collision)
    {
        //SceneManager.LoadScene(nextSceneToLoad);
        Game.Menu();
        ScreenPlay.SetActive(false);
        ScreenWin.SetActive(true);
    }
}
