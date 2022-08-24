using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttackController : MonoBehaviour, IAttackManager
{
    [SerializeField]private InputAction playerAttack;
    [SerializeField]private Transform projectileSpawner;
    [SerializeField]private GameObject projectile;
    [SerializeField]private float attackDelay;
    
    private bool isAttacking;
    public bool IsAttacking{
        get{return isAttacking;}
    }

    public float GetAttackDelay{
        get{return attackDelay;}
    } 

    private void OnEnable() {
        playerAttack.Enable();
    }

    private void OnDisable() {
        playerAttack.Disable();
    }

    private void Awake() {
        isAttacking = false;
        attackDelay = 0;
        projectileSpawner = transform.GetChild(3).gameObject.transform;
    }

    public void Update(){
        attackDelay += Time.deltaTime;
        if (attackDelay >= 0.05f) attackDelay = 0f;
        playerAttack.performed += ctx => isAttacking = true; 
        playerAttack.canceled += ctx => isAttacking = false;
        
    }

    public void Shoot(Projectile projectile){
        Instantiate(projectile, projectileSpawner.position, Quaternion.identity);
        SoundFXManager._SingleInstance.PlayerShootingSFXPlay();
    }
}
