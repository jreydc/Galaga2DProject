using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Enemy : MonoBehaviour { 
    public System.Action<Enemy> killed;
    private UnitAnimator unitAnim82r;
    private EnemyMovementController enemyMovementController;
    [SerializeField]private Unit enemyAttributes;
    
    [SerializeField]private float time2Attack;
    private bool moveTowardsDPlayer;

    //Initializations for Projectiles
    [SerializeField]private Transform projectileSpawner;
    [SerializeField]private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
        enemyMovementController = GetComponent<EnemyMovementController>();
        projectileSpawner = transform.GetChild(3).gameObject.transform;
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
        if(time2Attack >= 0.5f){
            Shoot();
            time2Attack = 0f;
        }

        if(killed != null){
            killed?.Invoke(this);
        }
    }

    private void FixedUpdate() {
       
        
    }


    private void Shoot(){
        Instantiate(projectile, projectileSpawner.position, Quaternion.identity);
        SoundFXManager._SingleInstance.InvaderShootingSFXPlay();
    }
}
