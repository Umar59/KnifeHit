using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    private GameObject gameManager;
    private KnifeCount knifeCount;

    private UnityEvent OnGameOver;
    private UnityEvent OnScoreUpdate;
    void OnEnable()
    {
        OnGameOver = new UnityEvent();
        OnScoreUpdate = new UnityEvent();
        
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        knifeCount = GameObject.FindGameObjectWithTag("KnifeCount").GetComponent<KnifeCount>();

        OnGameOver.AddListener(gameManager.GetComponent<GameManager>().GameOver);
        OnScoreUpdate.AddListener(gameManager.GetComponent<GameManager>().ScoreUpdate);
    }
    public void GameOver()
    {
        OnGameOver?.Invoke();
    }
    public void ScoreUpdate()
    {
        OnScoreUpdate?.Invoke();
    }

}
