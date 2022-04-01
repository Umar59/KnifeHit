using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshUpdate : MonoBehaviour
{
    [SerializeField] private GameObject stage;
    [SerializeField] private GameObject score;
    [SerializeField] private LvlTransition levelData;

    

    private void OnEnable()
    {
        stage.GetComponent<TMP_Text>().text = "STAGE: " + levelData.CurrentStage.ToString();
        score.GetComponent<TMP_Text>().text = levelData.CurrentKnifeScore.ToString();
    }
}
