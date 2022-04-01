using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStack : MonoBehaviour
{
    public static Stack<GameObject> state = new Stack<GameObject>(5);
}
