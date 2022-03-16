using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerOverlap : MonoBehaviour
{
    [SerializeField] private UnityEvent Trigger = new UnityEvent();
    public static GameObject _triggerCapture;

    public GameObject TriggerCapture { get => _triggerCapture; set => _triggerCapture = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _triggerCapture = collision.gameObject;
        Trigger?.Invoke();
    }
}
