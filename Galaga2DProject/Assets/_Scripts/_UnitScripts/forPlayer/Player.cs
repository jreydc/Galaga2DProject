using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class Player : UnitBase
{
    private PlayerMovementController playerMovementController;
    private PlayerAttackController playerAttackController;
    [SerializeField]private Unit playerAttributes;

    private bool _canMove;

    public override void Awake()
    {
        base.Awake();
        playerMovementController = GetComponent<PlayerMovementController>();
        playerAttackController = GetComponent<PlayerAttackController>();
        //unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
        SetStats(playerAttributes.BaseStats);

        GameManager.OnBeforeStateChanged += OnStateChanged;
    }

    private void OnDestroy() => GameManager.OnBeforeStateChanged -= OnStateChanged;

    private void OnStateChanged(GameState newState) {
        if (newState == GameState.BATTLE) _canMove = true;
    }

    // Update is called once per frame
    private void Update()
    {
        playerMovementController.UnitMovementDirection();
        if(playerMovementController.IsMoving){
            unitAnim82r.PlayerMoving();
        }else{
            unitAnim82r.PlayerIdle();
        }

        if(playerAttackController.IsAttacking && playerAttackController.GetAttackDelay == 0f){
            playerAttackController.Shoot(playerAttributes._projectile);
            Debug.Log("Shooting");
        }

    }

    private void FixedUpdate() {
        playerMovementController.UnitMovementComputations(Stats.speed);
    }
}
