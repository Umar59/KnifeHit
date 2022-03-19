using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _enemySpawnPoint;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private Skins _enemySkin;
    [SerializeField] private Skins _knifeSkin;

    [SerializeField] private EnemyRotation rotation;

    private void Start()
    {
        rotation = _enemySkin.GetSkin().Obj.GetComponent<EnemyRotation>();
        Spawn(_enemySkin.GetSkin());
        Spawn(_knifeSkin.GetSkin());
    }
    public void Spawn(ObjectsContainer objToSpawn)
    {
        if (objToSpawn.IsKnife)     Instantiate(objToSpawn.Obj, _playerSpawnPoint.position, Quaternion.Euler(0f, 0f, 0f));
        else                        Instantiate(objToSpawn.Obj, _enemySpawnPoint.position, Quaternion.Euler(0f, 0f, 0f));

        if (rotation = objToSpawn.Obj.GetComponent<EnemyRotation>())
        {
            rotation.CanRotate = true;
        }
    }
}

//gotta make this script reusable for spawning like..knives in log
//for that ill need to make arrays for sknis and transforms(not just two of each like now)
//also i will create an enum for object type. like it can be a knife, a log or just a knife spawned in log..?
//this script should be reused as many times as possible