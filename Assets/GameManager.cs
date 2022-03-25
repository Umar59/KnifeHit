using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LvlTransition transition;
    [SerializeField] private int maxLevel;
    [SerializeField] private Skins enemySkin;
    private EnemyDeath enemy;
    private bool isGameOver = false;
    private void OnEnable()
    {
        enemySkin.Stage = transition.CurrentStage;
        isGameOver = false;
    }
    public void GameOver()
    {
        isGameOver = true;
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyDeath>();
        enemy.StopSequence();
        SceneManager.LoadScene("MainMenu");
        //save score and move to main menu
    }
    public void Win()
    {
        if (!isGameOver)
        {
            if (transition.CurrentLevel < maxLevel)
            {
                transition.CurrentLevel++;
                SceneManager.LoadScene("GameScene");
            }
            else if (transition.CurrentLevel == maxLevel)
            {
                transition.CurrentLevel = 1;
                transition.CurrentStage++;

                if (enemySkin.SkinContainers.Length < enemySkin.Stage +1)
                {
                    transition.CurrentStage = 1;
                    enemySkin.Stage = 1;
                }
                else enemySkin.Stage = transition.CurrentStage;

            }
            Debug.Log($"level: {transition.CurrentLevel}");
            Debug.Log($"stage: {transition.CurrentStage}");
        }
    }
}
