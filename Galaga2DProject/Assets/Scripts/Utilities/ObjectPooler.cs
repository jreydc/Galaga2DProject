using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    //public Dictionary<string, Queue<GameObject>> poolDictionary => new Dictionary<string, Queue<GameObject>>();
    private Queue<GameObject> collectionOfPools = new Queue<GameObject>();

    public void FillThePoolCollection()
    {
        foreach (Pool pool in pools)
        {
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                collectionOfPools.Enqueue(obj); 
            }

        }
    }

    public GameObject SpawnFromPool(Vector3 position, Quaternion rotation)
    {
        if (collectionOfPools.Count > 0){
            GameObject objectToSpawn = collectionOfPools.Dequeue();
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = rotation;
            objectToSpawn.SetActive(true);
            return objectToSpawn;
        }
        return null;
    }

    public void ReturnToPool(GameObject obj){
        collectionOfPools.Enqueue(obj);
        obj.SetActive(false);
    }
}
