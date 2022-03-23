using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOKnifeInstance : MonoBehaviour
{
    [SerializeField] private ObjectsContainer _knife;
    private GameObject _instantiatedKnife;
    public ObjectsContainer Knife { get => _knife; set => _knife = value; }

    private void Start()
    {
        KnifeInstantiate();
    }
    //to avoid multiple time instantiating we must make a pool?...
    public void KnifeInstantiate()
    {
        _instantiatedKnife = Instantiate(_knife.Obj, transform.parent.position, Quaternion.Euler(0f, 0f, 0f));
        _instantiatedKnife.transform.parent = transform;
        _instantiatedKnife.transform.localPosition = Vector3.zero;

        _instantiatedKnife.GetComponent<SpriteRenderer>().sortingLayerName = "Knives";
        _instantiatedKnife.GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        _instantiatedKnife.GetComponent<KnifeThrow>().enabled = false;
        _instantiatedKnife.GetComponent<InputManager>().enabled = false;

    }
}
