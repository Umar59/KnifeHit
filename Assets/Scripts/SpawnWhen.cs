using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnWhen : MonoBehaviour
{
    [SerializeField] private UnityEvent OnItemSpawn;
    [SerializeField] private ObjectsContainer _item;

    public ObjectsContainer Item { get => _item; set => _item = value; }

    private void Spawn()
    {
        OnItemSpawn?.Invoke();
    }
}
