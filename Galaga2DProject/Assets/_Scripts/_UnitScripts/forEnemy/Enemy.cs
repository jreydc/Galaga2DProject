using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Enemy : UnitBase { 
    private EnemyMovementController enemyMovementController;
    [SerializeField]private Unit enemyAttributes;
    [SerializeField]private float time2Attack;
    private bool moveTowardsDPlayer;

    //Initializations for Projectiles
    [SerializeField]private Transform projectileSpawner;

    // Start is called before the first frame update
    void Start()
    {        
        enemyMovementController = GetComponent<EnemyMovementController>();
        projectileSpawner = transform.GetChild(3).gameObject.transform;
        
        IsKilled += () => {
            //call here the 
            
        };
    }

    // Update is called once per frame
    private void Update()
    {
        /* 
            The Enemy/Invader structure is not yet fully finished and Single Responsibility Pattern is currently ongoing.
         */

        enemyMovementController.UnitMovementDirection();
        
        if(enemyMovementController.IsMoving){
            unitAnim82r.PlayerMoving();
        }

        time2Attack += Time.deltaTime;
        if(time2Attack >= 2f){
            Shoot();
            time2Attack = 0f;
            //IsKilled?.Invoke();
        }

/*         if(killed != null){
            killed += () => {
                gameObject.SetActive(false);
            };
        } */
    }

    private void FixedUpdate() {
       
    }


    private void Shoot(){
        //Instantiate(projectile, projectileSpawner.position, Quaternion.identity);
        ObjectPooler._SingleInstance.GetObjectFromPool("EnemyProjectile", projectileSpawner.position);
        SoundFXManager._SingleInstance.InvaderShootingSFXPlay();
    }
}
