using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : Singleton<SoundFXManager>
{
    //Unit SoundFX
    [SerializeField]private AudioSource playerShootSFX;
    [SerializeField]private AudioSource invaderShootSFX;
    [SerializeField]private AudioSource playerExplosionSFX;
    [SerializeField]private AudioSource invaderExplosionSFX;
    //BG Musics    
    [SerializeField]private AudioSource bgMusicGameplay;
    [SerializeField]private AudioSource bgMusicMainMenu;


    
    private void Start() {
        playerShootSFX = transform.GetChild(0).GetComponent<AudioSource>();
        invaderShootSFX = transform.GetChild(1).GetComponent<AudioSource>();
        bgMusicGameplay = transform.GetChild(2).GetComponent<AudioSource>();
        bgMusicMainMenu = transform.GetChild(3).GetComponent<AudioSource>();
    }
    public void PlayerShootingSFXPlay(){
        playerShootSFX.Play();
    }

    public void InvaderShootingSFXPlay(){
        invaderShootSFX.Play();
    }

    public void BGMusicGamePlay(){
        bgMusicGameplay.Play();
    }

    public void BGMusicMainMenuPlay(){
        bgMusicMainMenu.Play();
    }

    public void BGMusicGameStop(){
        bgMusicGameplay.Stop();
    }

    public void BGMusicMainMenuStop(){
        bgMusicMainMenu.Stop();
    }
}
