using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skins", menuName = "Skins")]
public class Skins : ScriptableObject
{
    [SerializeField] private ObjectsContainer[] skinContainers;
    private Dictionary<string, ObjectsContainer> _skinsDictionary;
    public string selectedSkinName;
    public int stage = 1;

    public int Stage { get => stage; set => stage = value; }
    public ObjectsContainer[] SkinContainers => skinContainers;

    private void OnEnable()
    {
        _skinsDictionary = new Dictionary<string, ObjectsContainer>();
        for (int i = 0; i < skinContainers.Length; i++)
        {
            _skinsDictionary.Add(skinContainers[i].ObjName, skinContainers[i]);
        }
    }
    public ObjectsContainer GetSkin()
    {
        foreach (var skin in _skinsDictionary)
        {
            if (skin.Value.EnemyStage == stage && skin.Value.ObjectTypeGetter == ObjectsContainer.ObjectType.Enemy) { return _skinsDictionary[skin.Key]; }
        }
        return _skinsDictionary[selectedSkinName];
    }

}
