using UnityEngine;
using UnityEngine.InputSystem;

public class UnitAttackController : MonoBehaviour
{
    [SerializeField]private InputAction playerAttack;
    [SerializeField]private Transform projectileSpawner;
    [SerializeField]private GameObject projectile;

    private bool isAttacking;
    public bool IsAttacking{
        get{return isAttacking;}
    } 

    private void OnEnable() {
        playerAttack.Enable();
    }

    private void OnDisable() {
        playerAttack.Disable();
    }

    private void Awake() {
        projectileSpawner = transform.GetChild(3).gameObject.transform;
    }

    public void Update(){
        playerAttack.performed += ctx => isAttacking = true;
        playerAttack.canceled += ctx => isAttacking = false;
    }

    public void Shoot(){
        Instantiate(projectile, projectileSpawner.position, Quaternion.identity);
    }
}
