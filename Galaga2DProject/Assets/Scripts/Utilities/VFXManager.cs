using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : Singleton<VFXManager>
{
    [SerializeField]private GameObject invaderVFXExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InvaderVFXExplosionPlay(Vector3 position){
        Instantiate(invaderVFXExplosion, position, Quaternion.identity);
    }
}
