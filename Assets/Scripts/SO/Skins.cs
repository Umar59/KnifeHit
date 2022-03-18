using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skins", menuName = "Skins")]
public class Skins : ScriptableObject
{
    [SerializeField] private ObjectsContainer[] _skins;
    public Dictionary<string, ObjectsContainer> skinsDictionary;
    public string selectedSkinName;

    private void OnEnable()
    {
        skinsDictionary = new Dictionary<string, ObjectsContainer>();
        for (int i = 0; i < _skins.Length; i++)
        {
            skinsDictionary.Add(_skins[i].ObjName, _skins[i]);
        }
    }
    public void ShowSkins()
    {
      
        foreach (var skin in skinsDictionary)
        {
           //Debug.Log($"key:{skin.Key} objName: {skin.Value.ObjName} name: {skin.Value.name}");
          //  Debug.Log(skinsDictionary.Count);
        }
    }
    public ObjectsContainer GetSkin()
    {
        return skinsDictionary[selectedSkinName];
    }

}
