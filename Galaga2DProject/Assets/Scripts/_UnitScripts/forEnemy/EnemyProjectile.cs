using UnityEngine;

public class EnemyProjectile : Projectile
{    
    public override void OnDestroy() {
        base.OnDestroy();
    }
    public override void CheckCollision(Collider2D other)
    {
        if (other.tag == "Player"){
            Destroy(gameObject);
        }

    }

    private void Update() {
        ProjectileMovement();
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        CheckCollision(other);    
    }
}
