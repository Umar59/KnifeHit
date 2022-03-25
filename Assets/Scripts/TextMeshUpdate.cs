using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshUpdate : MonoBehaviour
{
    [SerializeField] private GameObject stage;
    [SerializeField] private GameObject knifeHit;
    [SerializeField] private LvlTransition levelData;

    private void OnEnable()
    {
        stage.GetComponent<TMP_Text>().text = levelData.CurrentStage.ToString();
        knifeHit.GetComponent<TMP_Text>().text += levelData.CurrentLevel.ToString();
    }
}
