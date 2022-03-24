using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Enemy, player")]
    [SerializeField]
    private Skins[] skins;

    [Header("Knife skin menu you want to use on spawning knives")]
    [SerializeField]
    private Skins knifeSkin;
    public Skins[] Skins => skins;

    private void Start()
    {
        foreach (var skin in skins)
        {
            Spawn(skin.GetSkin());
        }
    }

    public void Spawn(ObjectsContainer objToSpawn)
    {
        if (objToSpawn.ObjectTypeGetter == ObjectsContainer.ObjectType.Enemy) SpawnKnives(objToSpawn);
        else Instantiate(objToSpawn.Obj, objToSpawn.SpawnPosition.transform.position,
                Quaternion.Euler(0f, 0f, 0f)).transform.GetComponent<KnifeThrow>().enabled = true;
    }

    private void SpawnKnives(ObjectsContainer objToSpawn)
    {
        GameObject instantiatedEnemy = Instantiate(objToSpawn.Obj, objToSpawn.SpawnPosition.transform.position,
            Quaternion.Euler(0f, 0f, 0f));

        for (int i = 0; i < objToSpawn.KnivesSpawning; i++)
        {
            //to spawn knives randomly around the log
            instantiatedEnemy.transform.Rotate(new Vector3(0f, 0f, 10f * Random.Range(1f, 35f)));
            GameObject instantiatedKnife = Instantiate(knifeSkin.GetSkin().Obj, new Vector3(0f, 0f, 0f),
                Quaternion.Euler(0f, 0f, 0f));
            instantiatedKnife.transform.parent = instantiatedEnemy.transform;
            instantiatedKnife.GetComponent<InputManager>().enabled = false;
            instantiatedKnife.GetComponent<KnifeThrow>().enabled = false;
            instantiatedKnife.GetComponent<Collider2D>().enabled = true;
        }
        instantiatedEnemy.transform.Rotate(new Vector3(0f, 0f, 10f * Random.Range(1f, 360f)));
    }
}

//upd 21.03 the script still looks like a piece of s...

//gotta make this script reusable for spawning like..knives in log
//for that ill need to make arrays for sknis and transforms(not just two of each like now)
//also i will create an enum for object type. like it can be a knife, a log or just a knife spawned in log..?
//this script should be reused as many times as possible