using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float touchDelay;
    public delegate void OnScreenTouch();
    public event OnScreenTouch OnTouch;
    private float timeElapsed;
    private Touch touch;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > touchDelay)
        {
            //for mobile                                                        //for pc
            if ((Input.touchCount > 0 && touch.phase == TouchPhase.Began) || Input.GetMouseButtonUp(0))
            {

                Debug.Log("delay");
                OnTouch?.Invoke();
                timeElapsed = 0;
            }
        }
    }
}
