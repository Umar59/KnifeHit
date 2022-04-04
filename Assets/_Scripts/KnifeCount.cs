using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeCount : MonoBehaviour
{
    [SerializeField] private Skins enemySkin;
    [SerializeField] private GameObject knifeCountUI;
    private GameObject[] knifeCountElements;
    private int totalCount;
    private int currentCount = 0;
    
    //leftBottom bar showing how many knives you have to throw to win 
    private void OnEnable()
    {
        GameManager.scoreUpdate += UpdateUI;
        totalCount = enemySkin.GetSkin().KnifeCapacity;
        knifeCountElements = new GameObject[totalCount];

        for (int i = 0; i < totalCount; i++)
        {
           knifeCountElements[i] = Instantiate(knifeCountUI, transform);
        }
    }
    public void UpdateUI(int score)
    {
        currentCount++;
        knifeCountElements[totalCount - currentCount].transform.GetComponent<Image>().color = Color.grey;
    }

    private void OnDisable()
    {
        GameManager.scoreUpdate -= UpdateUI;
    }
}
