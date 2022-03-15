using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuToGame : MonoBehaviour
{

                    // too dirty script
                    //must be rewritten!


    [SerializeField] private GameObject[] UI;
    [SerializeField] private float travelTime;
    [SerializeField] private float travelDistance;
    [SerializeField] private float knifeTravelTime;
    [SerializeField] private float knifeTravelDistance;
    private GameObject _canvas;

    private void Start() 
    { 
        _canvas = transform.parent.gameObject;
    }
    public void MoveOut()
    {
        foreach (GameObject UIElement in UI)    //dependency from literals must be disposed. Even looks strange
        {
            switch (UIElement.name)
            {
                case "StartButton":
                    UIElement.SetActive(false);
                    UIElement.transform.DOMoveX(UIElement.transform.position.x + travelDistance, travelTime, false);
                    UIElement.SetActive(true);
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

        SceneManager.LoadScene("GameScene");
        //_canvas.SetActive(false);
    }
}

