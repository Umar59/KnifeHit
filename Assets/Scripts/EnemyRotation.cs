using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] private Rotations[] rotations;
    [SerializeField] private GameObject obj;
    private bool _canRotate = true;
    public bool CanRotate { get => _canRotate; set => _canRotate = value; }

    private void OnEnable()
    {
        Rotation();
    }
    public void Rotation()
    {
        Sequence _sequence = DOTween.Sequence().SetAutoKill(false);

        foreach (Rotations rotation in rotations)
        {
            _sequence.Append(
                obj.transform.DORotate(obj.transform.localEulerAngles + new Vector3(0f, 0f, rotation.RotationDegrees * ((int)rotation.RotOrientation)),
                rotation.RotationTime, 
                RotateMode.FastBeyond360)).SetEase(Ease.Linear);
        }
        if (CanRotate)  _sequence.OnComplete(() => { _sequence.Restart(); });
        else            _sequence.Kill();

    }
        
}
