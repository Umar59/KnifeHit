using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField] private GameObject _optionsMenu;
    private GameObject _currentMenu;
    public MenuController options;
    public GameObject _previousMenu;                //this one also
    private void Start()
    {
        //options = _optionsMenu.GetComponent<MenuController>();                not working for some reason, so i had to make it public.. return to it later...
        _currentMenu = this.transform.parent.gameObject;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Options()
    {
        _optionsMenu.SetActive(true);
        _currentMenu.SetActive(false);
        options._previousMenu = _currentMenu;
    }

    public void Return(GameObject nextMenu)         //gameover scence return to main
    {
        _currentMenu.SetActive(false);
        nextMenu.SetActive(true);
    }
    public void Return()
    {
        _currentMenu.SetActive(false);
        _previousMenu?.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}