using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Control Control;
    public SnakeMovement Snake;

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    private void Start()
    {}

    public State CurrentState { get; private set; }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Won;
        Snake.ReachFinish();
        Control.enabled = false;
        Debug.Log("Finish!");
    }
}
