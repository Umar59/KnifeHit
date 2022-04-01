using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerOverlap : MonoBehaviour
{
    [SerializeField] private UnityEvent Trigger = new UnityEvent();
    public static string _triggerCapture;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _triggerCapture = collision.transform.parent.GetComponent<SOKnifeInstance>().Knife.ObjName;
        Trigger?.Invoke();
    }
}
