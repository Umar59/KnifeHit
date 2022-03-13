using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class UIDissolve : MonoBehaviour
{
    [SerializeField] private GameObject[] UI;
    [SerializeField] private float travelTime;
    [SerializeField] private float travelDistance;
    [SerializeField] private float knifeTravelTime;
    [SerializeField] private float knifeTravelDistance;

    private void Start()
    {
        MoveOut();
    }
    private void MoveOut()
    {
        foreach(GameObject UIElement in UI)
        {
            switch (UIElement.name)
            {
                case "StartButton" : Destroy(UIElement);
                    break;

                case "Knife":
                    UIElement.transform.DOMoveY(UIElement.transform.position.y + knifeTravelDistance*-1, knifeTravelTime);
                    break;

                default:
                    UIElement.transform.DOMoveX(UIElement.transform.position.x + travelDistance, travelTime, false);  
                    UIElement.GetComponent<Image>().CrossFadeAlpha(0, travelTime, false);

                    travelDistance *= -1;
                    break;
            }
            
        }
    }    
}

