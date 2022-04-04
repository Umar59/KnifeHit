using System;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreUpdate : MonoBehaviour
{
    [SerializeField] private UnityEvent OnScoreUpdate;
    private TMP_Text score;    

    private void OnEnable()
    {
        OnScoreUpdate?.Invoke();
        GameManager.scoreUpdate += GameScoreUpdate;
        
    }

    public void GameScoreUpdate(int score)
    {
        this.score = transform.GetComponent<TMP_Text>();
        this.score.text = score.ToString();
    }
    public void BestScoreUpdate()
    {
        score = transform.GetComponent<TMP_Text>();
        if (PlayerPrefs.HasKey("Score"))
        {
            score.text += " " + PlayerPrefs.GetInt("Score").ToString();
        }
        OnScoreUpdate.RemoveListener(BestScoreUpdate);
    }

    private void OnDisable()
    {
        GameManager.scoreUpdate -= GameScoreUpdate;
    }
}
