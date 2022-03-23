using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMock : MonoBehaviour
{
    private void OnEnable()
    {
        Instantiate(new GameObject(), transform.position, Quaternion.Euler(Vector3.zero));
    }
    //private void Update()
    //{
    //    timeElapsed += Time.deltaTime;
    //    if (canSpawn && timeElapsed > spawnDelay)
    //    {
    //        spawner.SpawnNewKnife();
    //        canSpawn = false;
    //        timeElapsed = 0;
    //    }
    //}
}
