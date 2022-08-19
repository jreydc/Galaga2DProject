using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : Singleton<VFXManager>
{
    [SerializeField]private GameObject invaderVFXExplosion;
    
    public void InvaderVFXExplosionPlay(Vector3 position){
        Instantiate(invaderVFXExplosion, position, Quaternion.identity);
    }
}
