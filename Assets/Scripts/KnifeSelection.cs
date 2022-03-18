using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSelection : MonoBehaviour
{

    public void KnifeSelecting()
    {
        
        Debug.Log(TriggerOverlap._triggerCapture.name);
    }
    public void KnifeSelected()
    {
        Debug.Log("knifeSelected");
        Debug.Log(TriggerOverlap._triggerCapture.name);
        
    }
}
