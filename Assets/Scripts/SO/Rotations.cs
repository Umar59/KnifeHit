using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Rotation", menuName = "Rotation")]
public class Rotations : ScriptableObject
{
    public enum Orientation { right= 1, left =-1 };
    [SerializeField] private Orientation rotOrientation;
    [Tooltip("Rotation speed value measured in degrees per second")]
    [SerializeField] private float rotationDegrees; 
    [SerializeField] private float acceleration;
    [SerializeField] private float rotationTime;

    public Orientation RotOrientation { get => rotOrientation; }
    public float RotationDegrees { get => rotationDegrees; set => rotationDegrees = value; }
    public float Acceleration { get => acceleration; }
    public float RotationTime { get => rotationTime; }
}
