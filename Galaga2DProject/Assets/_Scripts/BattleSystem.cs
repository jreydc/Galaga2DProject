/* 
Reference for the Battle System structure would be from Code Monkey YT channel:
Simple Battle System in Unity
https://www.youtube.com/watch?v=gbFBWxtpgpQ&t=1285s

Reference on the possible gameplay and enemy animation: Zigurous YT Channel (https://www.youtube.com/c/Zigurous)

How to make Space Invaders in Unity (Complete Tutorial)
https://www.youtube.com/watch?v=qWDQgmdUzWI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    /* 
        not finished yet...formulating other features of the BattleSystems like as follows:
        1. Round Managers that manages the wave of the enemies, round details and information that connects with Game Managers about the game states (START, INPLAY, END).
        2. Health Systems that manages the health of the player and the enemies
        3. VFX Managers that handles the visual effects
        4. SoundFX Managers that handles the sound effects
        5. UI Managers that handles the UIs, menus and buttons of the games interfaces.
     */
     
    [SerializeField]private Transform enemySpawnPoint;
    [SerializeField]private Transform enemyStayPoint;
    [SerializeField]private float maxPosition;
    private int gridRows => 4;
    private int gridColumns => ObjectPooler._SingleInstance.pools[2].size;// population of the Invaders
    private float screen => Screen.width;

    private void Awake() {
    
    }


    void Start()
    {
        //_enemyObjectPooler = GetComponent<ObjectPooler>();
        ObjectPooler._SingleInstance.FillThePoolCollection();
        InvokeRepeating("SpawnWaveOfEnemies", 0, 5);
        SpawnWaveOfEnemies();
        Debug.Log(screen);

    }

    void Update()
    {
        
    }

    private void SpawnWaveOfEnemies(){
        //Vector3 enemyPosition = new Vector3(Random.Range(-maxPosition, maxPosition), enemySpawnPoint.localPosition.y, enemySpawnPoint.localPosition.z);
        ObjectPooler._SingleInstance.GetObjectFromPool("Invaders",enemySpawnPoint.localPosition);
    }
}
