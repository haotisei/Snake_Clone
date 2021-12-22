using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneToLoad : MonoBehaviour
{
    private int nextSceneToLoad;

    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;    
    }

  private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
