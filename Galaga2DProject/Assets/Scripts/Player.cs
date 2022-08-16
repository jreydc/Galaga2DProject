using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : Unit
{
    private UnitAnimator unitAnim82r;
    private Rigidbody2D rgBody2D;
    [SerializeField]private InputAction playerMovement;
    [SerializeField]private float moveSpeed;

    private Vector2 moveDirection = Vector2.zero;

    private void OnEnable() {
        playerMovement.Enable();
    }

    private void OnDisable() {
        playerMovement.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        moveDirection = playerMovement.ReadValue<Vector2>();
    }

    private void FixedUpdate() {
        rgBody2D.velocity = new Vector2(moveDirection .x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
