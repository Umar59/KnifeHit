using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOKnifeInstance : MonoBehaviour
{
    [SerializeField] private ObjectsContainer _knife;
    private SpriteRenderer _originalKnife;
    public ObjectsContainer Knife { get => _knife; set => _knife = value; }

    private void OnEnable()
    {
        _originalKnife = transform.GetChild(0).GetComponent<SpriteRenderer>();
        KnifeInstantiate();
    }
    public void KnifeInstantiate()
    {
        _originalKnife.sprite = _knife.Obj.GetComponent<SpriteRenderer>().sprite;
        _originalKnife.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        _originalKnife.sortingLayerName = "Knives";
    }
}
