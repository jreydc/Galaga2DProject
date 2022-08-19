using UnityEngine;

public class EnemyProjectile : Projectile
{    
    public override void OnDestroy() {
        base.OnDestroy();
    }

    public override void CheckCollision(Collider2D other)
    {
        if (other.tag == "Player"){//Destroy temporarily...planning to utilize the Object Pooler ReturnToPool method soon.
            Destroy(gameObject);
            Destroy(other.gameObject); 
        }

    }

    private void Update() {
        ProjectileMovement();
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        CheckCollision(other);    
    }

    public override void ProjectileMovement()
    {
        transform.position += -direction * projectileSpeed * Time.deltaTime;
    }
}
