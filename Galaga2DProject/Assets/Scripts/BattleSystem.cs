using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    ObjectPooler _objectPooler;
    [SerializeField]private float maxPosition;
    // Start is called before the first frame update
    void Start()
    {
        _objectPooler = ObjectPooler._SingleInstance;
        _objectPooler.FillThePoolCollection();
        StartBattle();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void StartBattle(){
        Vector3 enemyPosition = new Vector3(Random.Range(-maxPosition, maxPosition), transform.position.y, transform.position.z);
        _objectPooler.SpawnFromPool("Invaders", enemyPosition, Quaternion.identity);
    }
}
