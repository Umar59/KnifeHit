using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKnife : MonoBehaviour
{
    [SerializeField] private GameObject knifeParent;
    [SerializeField] private Skins knifeSkin;
    private GameObject knifeInstance;

    private void OnEnable()
    {
        knifeInstance = Instantiate(knifeSkin.GetSkin().Obj, Vector3.zero, Quaternion.Euler(Vector3.zero));
        knifeInstance.transform.parent = knifeParent.transform;
        knifeInstance.transform.localPosition = new Vector3(0f, 35f, 0f);
    }
    public void KnifeDestroy()
    {
        Debug.Log("destroy");
        Destroy(knifeInstance);
    }
}
