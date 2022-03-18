using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class ObjectsContainer : ScriptableObject
{
    [SerializeField] private GameObject obj;
    [SerializeField] private int knifeCapacity;
    [SerializeField] private bool isKnife;
    [SerializeField] private string objName;

    public GameObject Obj { get => obj; }
    public int KnifeCapacity { get => knifeCapacity; }
    public bool IsKnife { get => isKnife; }
    public string ObjName { get => objName; set => objName = value; }
}
