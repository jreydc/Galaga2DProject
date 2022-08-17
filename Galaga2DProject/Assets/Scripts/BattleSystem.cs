using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : Spawner
{
    ObjectPooler _objectPooler;
    [SerializeField]private float maxPosition;
    // Start is called before the first frame update
    void Start()
    {
        _objectPooler = ObjectPooler._SingleInstance;
        _objectPooler.FillThePoolCollection();
        InvokeRepeating("StartBattle", 0, 3);
    }

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        TimeToSpawn();

        if(Input.GetKeyDown(KeyCode.Space)){
            _objectPooler.ReturnToPool(newPool);    
        }
    }

    private void StartBattle(){
        Vector3 enemyPosition = new Vector3(Random.Range(-maxPosition, maxPosition), transform.position.y, transform.position.z);
        _objectPooler.SpawnFromPool(enemyPosition, Quaternion.identity);
    }
}
