using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField] private Rotations[] rotations;
    [SerializeField] private GameObject obj;

    private Sequence sequence;

    public bool CanRotate { get; set; } = true;
    public Sequence rotSequence { get => sequence; set => sequence = value; }

    private void OnEnable()
    {
        Rotation();
    }

    public void Rotation()
    {
        sequence = DOTween.Sequence();

        foreach (Rotations rotation in rotations)
        {
            sequence.Append(
                obj.transform.DORotate(new Vector3(0f, 0f,
                        rotation.RotationDegrees * ((int)rotation.RotOrientation)),
                    rotation.RotationTime,
                    RotateMode.FastBeyond360)).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
        }

        //if (CanRotate) sequence.OnComplete(() => { sequence.Kill(); Rotation(); });
        //else sequence.Kill();
    }
}