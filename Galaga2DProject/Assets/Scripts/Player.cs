using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Unit
{
    private UnitAnimator unitAnim82r;
    private UnitMovementController unitMovementController;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        unitMovementController = GetComponent<UnitMovementController>();
        unitAnim82r = 
    }

    // Update is called once per frame
    private void Update()
    {
        /* float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized; */
        
        //moveDirection = playerMovement.ReadValue<Vector2>();
        unitMovementController.MovementDirectionReadValues();
    }

    private void FixedUpdate() {
        //rgBody2D.velocity = new Vector2(moveDirection .x * moveSpeed, moveDirection.y * moveSpeed);
        unitMovementController.Rigidbody2DToMovement();
    }
}
