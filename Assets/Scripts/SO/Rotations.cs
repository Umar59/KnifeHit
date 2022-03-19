using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Rotation", menuName = "Rotation")]
public class Rotations : ScriptableObject
{
    public enum Orientation
    {
        Right = 1,
        Left = -1
    };

    [SerializeField] private Orientation rotOrientation;

    [Tooltip("Rotation per tween(measured in degrees)")] [SerializeField]
    private float rotationDegrees;

    [Tooltip("Time consumed by a tween")] [SerializeField]
    private float rotationTime;

    [SerializeField] private float acceleration;

    public Orientation RotOrientation => rotOrientation;
    public float RotationDegrees => rotationDegrees;
    public float Acceleration => acceleration;
    public float RotationTime => rotationTime;
}