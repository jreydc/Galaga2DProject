using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour, IMovementManager
{
    private Rigidbody2D rgBody2D;
    [SerializeField]private InputAction playerMovement;
    private Vector2 moveDirection = Vector2.zero;   

    private bool isMoving;
    public bool IsMoving{
        get{return isMoving;}
    } 

    private void OnEnable() {
        playerMovement.Enable();
    }

    private void OnDisable() {
        playerMovement.Disable();
    }

    private void Awake() {
        rgBody2D = GetComponent<Rigidbody2D>();
        isMoving = false;    
    }

    
    public void UnitMovementDirection(){
        moveDirection = playerMovement.ReadValue<Vector2>();
        playerMovement.performed += ctx => isMoving = true;
        playerMovement.canceled += ctx => isMoving = false;
    }

    public void UnitMovementComputations(float moveSpeed){
        rgBody2D.velocity = new Vector2(moveDirection .x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
