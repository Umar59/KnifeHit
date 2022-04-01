using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Transition", menuName = "Level Transition")]
public class LvlTransition : ScriptableObject
{
    [SerializeField] private int currentLevel;
    [SerializeField] private int currentStage;
    [SerializeField] private int currentKnifeScore;
    private void OnEnable()
    {
        currentLevel = 1;
        currentStage = 1;
        currentKnifeScore = 0;
    }

    public void Restart()
    {
        currentKnifeScore = 0;
        currentLevel = 1;
        currentStage = 1;
    }
    public int CurrentLevel { get => currentLevel; set => currentLevel = value; }
    public int CurrentStage { get => currentStage; set => currentStage = value; }
    public int CurrentKnifeScore { get => currentKnifeScore; set => currentKnifeScore = value; }
}
