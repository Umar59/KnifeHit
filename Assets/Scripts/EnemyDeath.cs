using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;


public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private Skins currentSkin;
    private EnemyRotation rotation;
    private int knifeCapacity;
    private GameObject gameManager;
    private UnityEvent OnWin = new UnityEvent();
    private void OnEnable()
    {
        knifeCapacity = currentSkin.GetSkin().KnifeCapacity + currentSkin.GetSkin().KnivesSpawning;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        OnWin.AddListener(gameManager.GetComponent<GameManager>().Win);
        OnWin.AddListener(StopSequence);
        rotation = gameObject.GetComponent<EnemyRotation>();
    }
    private void Update()
    {
        if (transform.childCount == knifeCapacity) { OnWin?.Invoke(); }
    }
    public void StopSequence()
    {
        rotation.rotSequence.Kill();
    }
}
