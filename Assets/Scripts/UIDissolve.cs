using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UIDissolve : MonoBehaviour
{

                    // too dirty script
                    //must be rewritten!


    [SerializeField] private GameObject[] UI;
    GameObject canvas;
    [SerializeField] private float travelTime;
    [SerializeField] private float travelDistance;
    [SerializeField] private float knifeTravelTime;
    [SerializeField] private float knifeTravelDistance;

    private void Start()
    {
        canvas = transform.parent.gameObject;
        canvas.SetActive(true);
        MoveOut();
    }
    private void MoveOut()
    {
        foreach (GameObject UIElement in UI)    //dependency from literals must be disposed. Even looks strange
        {
            switch (UIElement.name)
            {
                case "StartButton":
                    Destroy(UIElement);
                    break;

                case "Knife":
                    UIElement.transform.DOMoveY(UIElement.transform.position.y + knifeTravelDistance * -1, knifeTravelTime);
                    break;

                default:
                    UIElement.transform.DOMoveX(UIElement.transform.position.x + travelDistance, travelTime, false);
                    UIElement.GetComponent<Image>().CrossFadeAlpha(0, travelTime, false);
                    break;
            }
            travelDistance *= -1;
        }
        StartCoroutine(WaitForUI(travelTime));
        
    }
    private IEnumerator WaitForUI(float time)
    {
        yield return new WaitForSeconds(time);
        canvas.SetActive(false);
    }
}

