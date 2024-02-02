using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class EndGame : MonoBehaviour
{
    public UnityEvent endGame;
    public UnityEvent animEndGame;

    public void GameEnder()
    {
        endGame.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        animEndGame.Invoke();
    }
}