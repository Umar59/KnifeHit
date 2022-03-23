using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private Skins currentSkin;
    private int knifeCapacity;
    private GameObject gameManager;
    public UnityEvent OnWin = new UnityEvent();
    private void OnEnable()
    {
        knifeCapacity = currentSkin.GetSkin().KnifeCapacity + currentSkin.GetSkin().KnivesSpawning;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        OnWin.AddListener(gameManager.GetComponent<GameManager>().Win);
    }
    private void Update()
    {
        if (transform.childCount == knifeCapacity) { OnWin?.Invoke(); }
    }
}
