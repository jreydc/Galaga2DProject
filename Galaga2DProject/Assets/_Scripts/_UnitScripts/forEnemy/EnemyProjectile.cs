using UnityEngine;

public class EnemyProjectile : Projectile
{    
    public override void OnDestroy() {
        base.OnDestroy();
    }

    public override void CheckCollision(Collider2D other)
    {
        base.CheckCollision(other);
        if (other.tag == "Player"){//Destroy temporarily...planning to utilize the Object Pooler ReturnToPool method soon.
            /* 
                The lines of code below should be included in an event to know the Enemy is killed, synchronously connected also to the Health System.
             */
            Destroy(other.gameObject);
            SoundFXManager._SingleInstance.PlayerExplosionSFXPlay();
            VFXManager._SingleInstance.PlayerVFXExplosionPlay(other.gameObject.transform.position); 
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
