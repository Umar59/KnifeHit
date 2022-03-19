using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Enemy, player")] [SerializeField]
    private Skins[] skins;

    [Header("Knife skin menu you want to use on spawning knives")] [SerializeField]
    private Skins knifeSkin;

    private void Start()
    {
        foreach (var skin in skins)
        {
            Spawn(skin.GetSkin());
        }
    }

    private void Spawn(ObjectsContainer objToSpawn)
    {
        if (objToSpawn.ObjectTypeGetter == ObjectsContainer.ObjectType.Enemy) SpawnKnives(objToSpawn);
        else Instantiate(objToSpawn.Obj, objToSpawn.SpawnPosition.transform.position,
                Quaternion.Euler(0f, 0f, 0f));
    }

    private void SpawnKnives(ObjectsContainer objToSpawn)
    {
        GameObject instantiatedEnemy = Instantiate(objToSpawn.Obj, objToSpawn.SpawnPosition.transform.position,
            Quaternion.Euler(0f, 0f, 0f));
 
        for (int i = 0; i < objToSpawn.KnivesSpawning; i++)
        {
            //to spawn knives randomly around the log
            instantiatedEnemy.transform.Rotate(new Vector3(0f, 0f,10f * Random.Range(1f, 35f) ));       
            GameObject instantiatedKnife = Instantiate(knifeSkin.GetSkin().Obj, new Vector3(0f, 0f, 0f),
                Quaternion.Euler(0f, 0f, 0f));
            instantiatedKnife.transform.parent = instantiatedEnemy.transform;
        }

    }
}

//gotta make this script reusable for spawning like..knives in log
//for that ill need to make arrays for sknis and transforms(not just two of each like now)
//also i will create an enum for object type. like it can be a knife, a log or just a knife spawned in log..?
//this script should be reused as many times as possible