using UnityEngine;

public class EnemyProjectile : Projectile
{    
    public override void OnDestroy() {
        base.OnDestroy();
    }

    public override void CheckCollision(Collider2D other)
    {
        if (other.tag == "Player"){
            ObjectPooler._SingleInstance.ReturnToPool(other.gameObject);
            SoundFXManager._SingleInstance.PlayerExplosionSFXPlay();
            VFXManager._SingleInstance.PlayerVFXExplosionPlay(other.gameObject.transform.position); 
        }
        base.CheckCollision(other);
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
