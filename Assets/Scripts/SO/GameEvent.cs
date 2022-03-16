using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New GameEvent", menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    private List<GameEventListner> listners = new List<GameEventListner>();

    public void Raise()
    {
        foreach(GameEventListner listner in listners)
        {
            listner.OnEventRaised();
        }
    }
    public void RegisterListner(GameEventListner listner)
    {
        listners.Add(listner);   
    }
    public void UnregisterListner(GameEventListner listner)
    {
        listners.Remove(listner);
    }
}
