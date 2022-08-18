using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CapsuleCollider2D))]
public class Player : Unit
{
    private UnitAnimator unitAnim82r;
    private UnitMovementController unitMovementController;
    private UnitAttackController unitAttackController;

    private void Awake()
    {
        unitMovementController = GetComponent<UnitMovementController>();
        unitAttackController = GetComponent<UnitAttackController>();
        unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
    }

    // Update is called once per frame
    private void Update()
    {
        unitMovementController.MovementDirectionReadValues();
        if(unitMovementController.IsMoving){
            unitAnim82r.PlayerMoving();
        }else{
            unitAnim82r.PlayerIdle();
        }

        if(unitAttackController.IsAttacking){
            unitAttackController.Shoot();
        }

    }

    private void FixedUpdate() {
        unitMovementController.Rigidbody2DToMovement();
    }
}
