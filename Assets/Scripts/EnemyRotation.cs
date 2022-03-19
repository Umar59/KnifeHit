using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] private Rotations[] rotations;
    [SerializeField] private GameObject obj;

    public bool CanRotate { get; set; } = true;

    private void OnEnable()
    {
        Rotation();
    }

    public void Rotation()
    {
        Sequence sequence = DOTween.Sequence().SetAutoKill(false);

        foreach (Rotations rotation in rotations)
        {
            sequence.Append(
                obj.transform.DORotate(
                    obj.transform.localEulerAngles + new Vector3(0f, 0f,
                        rotation.RotationDegrees * ((int) rotation.RotOrientation)),
                    rotation.RotationTime,
                    RotateMode.FastBeyond360)).SetEase(Ease.Linear);
        }

        if (CanRotate) sequence.OnComplete(() => { sequence.Restart(); });
        else sequence.Kill();
    }
}