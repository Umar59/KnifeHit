using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListner : MonoBehaviour
{
    [SerializeField] private UnityEvent response = new UnityEvent();
    [SerializeField] private GameEvent gameEvent;

    private void OnEnable()
    {
        gameEvent.RegisterListner(this);   
    }
    private void OnDisable()
    {
        gameEvent.UnregisterListner(this);
    }
    public void OnEventRaised()
    {
        response?.Invoke();
    }
}
