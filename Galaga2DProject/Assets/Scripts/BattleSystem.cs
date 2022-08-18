using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : Spawner
{
    [SerializeField]private ObjectPooler _enemyObjectPooler;
    [SerializeField]private float maxPosition;
    // Start is called before the first frame update
    void Start()
    {
        _enemyObjectPooler = GetComponent<ObjectPooler>();
        //_enemyObjectPooler.FillThePoolCollection();
        InvokeRepeating("StartBattle", 0, 3);
    }

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        //TimeToSpawn();
    }

    private void StartBattle(){
        Vector3 enemyPosition = new Vector3(Random.Range(-maxPosition, maxPosition), transform.position.y, transform.position.z);
        //_enemyObjectPooler.SpawnFromPool(enemyPosition, Quaternion.identity);
    }
}
