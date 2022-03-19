using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class ObjectsContainer : ScriptableObject
{
    [SerializeField] private GameObject obj;
    [SerializeField] private int knifeCapacity;
    [SerializeField] private int knivesSpawning;
    [SerializeField] private bool isKnife;
    [SerializeField] private string objName;
    public GameObject Obj { get => obj; }
    public int KnifeCapacity { get => knifeCapacity; }
    public bool IsKnife { get => isKnife; }
    public string ObjName { get => objName; set => objName = value; }
    private void OnEnable()
    {
        knifeCapacity += knivesSpawning; 
                                            //say log destroys when you throw 4 knives in it. (knifeCapacity)
                                            //But if it will have 3 of them alredy in it you will have to just throw one more. (knifeSpawning)
                                            //Thats why we need to add number of spawned knives to log's knife capacity (knifeCapacity + knifeSpawning)
    }
}
