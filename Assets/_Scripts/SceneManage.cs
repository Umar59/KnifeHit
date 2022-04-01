using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private UnityEvent OnMenuChange = new UnityEvent();
    
    public static bool isLoadedMoreThanOnce = false;
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnEnable()
    {
        if (isLoadedMoreThanOnce)
        {
            OnMenuChange?.Invoke();
            mainMenu.SetActive(false);
            gameOverMenu.SetActive(true);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "GameScene")
        {
            isLoadedMoreThanOnce = true;
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
}
