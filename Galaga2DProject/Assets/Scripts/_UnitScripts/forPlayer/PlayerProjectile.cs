using UnityEngine;

public class PlayerProjectile : Projectile
{
    public override void OnDestroy() {
        base.OnDestroy();
    }
    public override void CheckCollision(Collider2D other)
    {
        if (other.tag == "Enemy"){
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
