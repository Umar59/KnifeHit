using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class ObjectsContainer : ScriptableObject
{
    [SerializeField] private GameObject obj;
    [SerializeField] private int knifeCapacity;
    [SerializeField] private int knivesSpawning;
    [SerializeField] private string objName;
    [SerializeField] private GameObject spawnPosition;
    [SerializeField] private ObjectType objectType;
    [SerializeField] private int enemyStage;

    public GameObject Obj => obj;
    public int KnifeCapacity => knifeCapacity;
    public int KnivesSpawning => knivesSpawning;
    public string ObjName => objName;
    public GameObject SpawnPosition => spawnPosition;
    public ObjectType ObjectTypeGetter => objectType;

    public int EnemyStage => enemyStage;

    public enum ObjectType
    {
        Enemy,
        Knife,
        KnifeInEnemy
    }
}