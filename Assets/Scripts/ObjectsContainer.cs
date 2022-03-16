using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class ObjectsContainer : ScriptableObject
{
    public GameObject obj;

    public int knifeCapacity;
    public bool isKnife;
}
