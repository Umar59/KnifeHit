using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    private GameObject gameManager;
    private KnifeCount knifeCount;
    private UnityEvent OnGameOver;
    void OnEnable()
    {
        OnGameOver = new UnityEvent();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        knifeCount = GameObject.FindGameObjectWithTag("KnifeCount").GetComponent<KnifeCount>();
        OnGameOver.AddListener(gameManager.GetComponent<GameManager>().GameOver);
    }
    public void GameOver()
    {
        OnGameOver?.Invoke();
    }
    public void ScoreUpdate()
    {
        knifeCount.UpdateUI();
    }

}
