using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour, ISpawner
{
    public float timeToSpawn;
    public float timeSinceSpawn;
    public GameObject newPool;

    public void TimeToSpawn(){
        /* if (timeSinceSpawn >= timeToSpawn){
            newPool = ObjectPooler._SingleInstance.SpawnFromPool(transform.position, Quaternion.identity);
            timeSinceSpawn = 0f;
        } */
    }

    
}
