using UnityEngine;

public class PlayerProjectile : Projectile
{
    public override void OnDestroy() {
        base.OnDestroy();
    }
    public override void CheckCollision(Collider2D other)
    {
        if (other.tag == "Enemy"){//Destroy temporarily...planning to utilize the Object Pooler ReturnToPool method soon.
            Destroy(gameObject);
            Destroy(other.gameObject); 
            VFXManager._SingleInstance.InvaderVFXExplosionPlay(other.gameObject.transform.position);
        }
    }

    public override void OnEnable()
    {
        base.OnEnable();
    }

    private void Update() {
        ProjectileMovement();
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        CheckCollision(other);    
    }
}
