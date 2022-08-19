﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CapsuleCollider2D))]
public class Player : Unit
{
    private UnitAnimator unitAnim82r;
    private PlayerMovementController playerMovementController;
    private PlayerAttackController playerAttackController;

    private void Awake()
    {
        playerMovementController = GetComponent<PlayerMovementController>();
        playerAttackController = GetComponent<PlayerAttackController>();
        unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
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
            playerAttackController.Shoot();
            Debug.Log("Shooting");
        }

    }

    private void FixedUpdate() {
        playerMovementController.Rigidbody2DToMovement();
    }
}
