using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class KnifeThrow : MonoBehaviour
{
    [SerializeField] private float throwingSpeed;
    [SerializeField] private float throwingDistance;
    [SerializeField] private Spawner spawner;
    //event
    private Sequence sequence;

    public UnityEvent OnGameOver = new UnityEvent();
    private GameObject gameManager;

    private void OnEnable()
    {
        transform.GetComponent<InputManager>().OnTouch += Throw;
        transform.GetComponent<InputManager>().OnTouch += SpawnNewKnife;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        OnGameOver.AddListener(gameManager.GetComponent<GameManager>().GameOver);
    }
    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<Spawner>();
    }
    public void Throw()
    {
        transform.GetComponent<Collider2D>().enabled = true;
        sequence = DOTween.Sequence();
        transform.GetComponent<InputManager>().OnTouch -= Throw;
        sequence.Append( gameObject.transform.DOMoveY(transform.position.y + throwingDistance, throwingSpeed).SetEase(Ease.InBack));

    }

    public void SpawnNewKnife()
    {
        for(int i = 0; i < spawner.Skins.Length; i++)
        {
            if(spawner.Skins[i].GetSkin().ObjectTypeGetter == ObjectsContainer.ObjectType.Knife)
            { 
                spawner.Spawn(spawner.Skins[i].GetSkin());
                transform.GetComponent<InputManager>().OnTouch -= SpawnNewKnife;
                return;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            transform.parent = collision.collider.transform;
            transform.GetComponent<KnifeThrow>().enabled = false;
            transform.GetComponent<InputManager>().enabled = false;
            transform.GetComponent<Collider2D>().offset = new Vector2(0f, -0.85f);
            transform.GetComponent<BoxCollider2D>().size = new Vector2(0.58f, 0.62f);
            transform.tag = "Stuck Knife";
            sequence.Kill();
        }
        else if(collision.transform.tag == "Stuck Knife")
        {
            OnGameOver?.Invoke();
            Debug.Log("gameover");
        }
    }
}
