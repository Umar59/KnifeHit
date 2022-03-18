using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSelection : MonoBehaviour
{
    [SerializeField] private Skins skin;

    //here the knife in between will be highlighted
    public void KnifeSelecting() => Debug.Log(TriggerOverlap._triggerCapture); 
    public void KnifeSelected() => skin.selectedSkinName = TriggerOverlap._triggerCapture;

}
