using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MoveMenu: MonoBehaviour
{
    [SerializeField] private GameObject _nextMenu;
    [SerializeField] private UnityEvent OnGameStart;
    [SerializeField] private GameObject _currentMenu;

    private void Start()
    {
        //_currentMenu = this.transform.parent.gameObject;
    }
    public void Move(GameObject _nextMenu)
    {

        _nextMenu.SetActive(true);
        _currentMenu.SetActive(false);

        MenuStack.state.Push(_currentMenu);                 //adds current menu in the stack so next menu can return to current
    }
    public void Return()
    {
        _currentMenu.SetActive(false);
        MenuStack.state.Pop().SetActive(true);              //turns on previous menu

        MenuStack.state.Push(_currentMenu);                 
    }
    public void StartGame()
    {
        OnGameStart?.Invoke();
    }
}
