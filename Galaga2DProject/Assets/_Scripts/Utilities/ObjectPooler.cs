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
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    #region Single Instance
    public static ObjectPooler _objectPoolerInstance;

    private void Awake()
    {
        _objectPoolerInstance = this;
    }

    #endregion

    public void FillThePoolCollection()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                
                GameObject obj = Instantiate(pool.prefab, transform.position, Quaternion.identity);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDictionary.Add(tag, objectPool);
        }
        
    }

    public GameObject SpawnFromPool(Vector3 position, Quaternion rotation)
    {
        /* if (collectionOfPools.Count > 0){
            GameObject objectToSpawn = collectionOfPools.Dequeue();
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = rotation;
            objectToSpawn.SetActive(true);
            return objectToSpawn;
        } */
        return null;
    }

    public GameObject GetObjectFromPool(string tag, Vector3 position, Quaternion rotation){
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool doesn't exist - " + tag);
            return null;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }

    public void ReturnToPool(GameObject obj){
        //collectionOfPools.Enqueue(obj);
        obj.SetActive(false);
    }
}
