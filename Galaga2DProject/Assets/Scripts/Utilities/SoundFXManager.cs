using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : Singleton<SoundFXManager>
{
    [SerializeField]private AudioSource playerShootSFX;
    [SerializeField]private AudioSource invaderShootSFX;
    
    private void Start() {
        playerShootSFX = transform.GetChild(0).GetComponent<AudioSource>();
        invaderShootSFX = transform.GetChild(1).GetComponent<AudioSource>();
    }
    public void PlayerShootingSFXPlay(){
        playerShootSFX.Play();
    }

    public void InvaderShootingSFXPlay(){
        invaderShootSFX.Play();
    }
}
