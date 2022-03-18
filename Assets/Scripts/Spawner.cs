using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _enemySpawnPoint;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private ObjectsContainer objToSpawn;
    [SerializeField] private Skins knifeSkin;

    private void Start()
    {
        Spawn(objToSpawn);
        Spawn(knifeSkin.GetSkin());
    }
    public void Spawn(ObjectsContainer objToSpawn)
    {
        if (objToSpawn.IsKnife)     Instantiate(objToSpawn.Obj, _playerSpawnPoint.position, Quaternion.Euler(0f, 0f, 0f));
        else                        Instantiate(objToSpawn.Obj, _enemySpawnPoint.position, Quaternion.Euler(0f, 0f, 0f));
    }
}
