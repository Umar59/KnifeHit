using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float touchDelay;
    private float timeElapsed;
    public delegate void OnScreenTouch();
    public event OnScreenTouch OnTouch;
    private Touch touch;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > touchDelay)
        {
            //for mobile                                                        //for pc
            if ((Input.touchCount > 0 && touch.phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
            {
                OnTouch?.Invoke();      //must be rewritten
                timeElapsed = 0;
            }
        }
    }
}
