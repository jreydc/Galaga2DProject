using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : Singleton<Spawner>
{
    public GameObject Instantiator(GameObject obj, Vector3 position){
        //var instantiatedOBJ = Instantiate(obj, position, Quaternion.identity);
        return Instantiate(obj, position, Quaternion.identity);
    }    
}
