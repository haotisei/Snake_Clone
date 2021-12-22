using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public SnakeMovement Snake;
    public static GameState gameState;

    public enum GameState
    {
        Menu,
        Playing,
        Won,
        Loss,
    }
    void Awake()
    {
        SetGame();
        if (StatsSave.SnakeHP <= 0)
            StatsSave.SnakeHP = 4;
    }

    void Update()
    {
        if (StatsSave.HighScore < StatsSave.Score)
            StatsSave.HighScore = StatsSave.Score;
    }

    public void SetGame()
    {
        gameState = GameState.Playing;
        Debug.Log("Started");

    }

    public void GameWon()
    {
        gameState = GameState.Won;
        Debug.Log("Won");
    }

    public void GameLost()
    {
        gameState = GameState.Loss;
        Debug.Log("Lost");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        gameState = GameState.Menu;
    }
}
