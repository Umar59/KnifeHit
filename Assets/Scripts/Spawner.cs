using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _enemySpawnPoint;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private ObjectsContainer objToSpawn;
    [SerializeField] private ObjectsContainer objToSpawn3;
    private void Start()
    {
        Spawn(objToSpawn);
        Spawn(objToSpawn3   );
    }
    public void Spawn(ObjectsContainer objToSpawn)
    {
        Debug.Log("spawn");
        if (objToSpawn.isKnife)     Instantiate(objToSpawn.obj, _playerSpawnPoint.position, Quaternion.Euler(0f, 0f, 0f));
        else                        Instantiate(objToSpawn.obj, _enemySpawnPoint.position, Quaternion.Euler(0f, 0f, 0f));
    }
}
