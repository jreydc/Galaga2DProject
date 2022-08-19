using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : Singleton<VFXManager>
{
    [SerializeField]private GameObject invaderImpactVFXExplosion;
    [SerializeField]private GameObject playerImpactVFXExplosion;    
    
    public void InvaderVFXExplosionPlay(Vector3 position){
        Instantiate(invaderImpactVFXExplosion, position, Quaternion.identity);
    }

    public void PlayerVFXExplosionPlay(Vector3 position){
        Instantiate(playerImpactVFXExplosion, position, Quaternion.identity);
    }
}
