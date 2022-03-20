using UnityEngine;
using DG.Tweening;

public class KnifeThrow : MonoBehaviour
{
    [SerializeField] private float throwingSpeed;
    [SerializeField] private float throwingDistance;
    [SerializeField] private Spawner spawner;

    private void OnEnable()
    {
        transform.GetComponent<InputManager>().OnTouch += Throw;
        transform.GetComponent<InputManager>().OnTouch += SpawnNewKnife;
    }
    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<Spawner>();
    }
    public void Throw()
    {
        transform.GetComponent<InputManager>().OnTouch -= Throw;
        Debug.Log("touch");
        gameObject.transform.DOMoveY(transform.position.y + throwingDistance, throwingSpeed).SetEase(Ease.InBack).OnComplete(()=> { Destroy(gameObject); });
    }
    public void SpawnNewKnife()
    {
        for(int i = 0; i < spawner.Skins.Length; i++)
        {
            if(spawner.Skins[i].GetSkin().ObjectTypeGetter == ObjectsContainer.ObjectType.Knife)
            {
                Debug.Log("knife");
                spawner.Spawn(spawner.Skins[i].GetSkin());
                transform.GetComponent<InputManager>().OnTouch -= SpawnNewKnife;
                return;
            }
        }
    }

}
