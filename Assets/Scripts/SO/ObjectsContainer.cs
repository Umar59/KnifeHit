using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class ObjectsContainer : ScriptableObject
{
    [SerializeField] private GameObject obj;
    [SerializeField] private int knifeCapacity;
    [SerializeField] private bool isKnife;

    public GameObject Obj { get => obj; }
    public int KnifeCapacity { get => knifeCapacity; }
    public bool IsKnife { get => isKnife; }
}
