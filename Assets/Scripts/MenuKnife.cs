using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKnife : MonoBehaviour
{
    [SerializeField] private SpriteRenderer originalKnife;
    [SerializeField] private Skins knifeSkin;
    private void OnEnable()
    {
        originalKnife.sprite = knifeSkin.GetSkin().Obj.GetComponent<SpriteRenderer>().sprite;
    }
}
