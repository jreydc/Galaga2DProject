using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField]private float maxPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 enemyPosition = new Vector3(Random.Range(-maxPosition, maxPosition), transform.position.y, transform.position.z);
        ObjectPooler._SingleInstance.SpawnFromPool("Invaders", enemyPosition, Quaternion.identity);
    }
}
