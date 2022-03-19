using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skins", menuName = "Skins")]
public class Skins : ScriptableObject
{
    [SerializeField] private ObjectsContainer[] skins;
    private Dictionary<string, ObjectsContainer> _skinsDictionary;
    public string selectedSkinName;

    private void OnEnable()
    {
        _skinsDictionary = new Dictionary<string, ObjectsContainer>();
        for (int i = 0; i < skins.Length; i++)
        {
            _skinsDictionary.Add(skins[i].ObjName, skins[i]);
        }
    }
    public ObjectsContainer GetSkin() { return _skinsDictionary[selectedSkinName]; }

}
