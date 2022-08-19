using UnityEngine;

public class PlayerProjectile : Projectile
{
    public override void OnDestroy() {
        base.OnDestroy();
    }
    public override void CheckCollision(Collider2D other)
    {
        base.CheckCollision(other);
        if (other.tag == "Enemy"){//Destroy temporarily...planning to utilize the Object Pooler ReturnToPool method soon.
            /* 
                The lines of code below should be included in an event to know the Enemy is killed, synchronously connected also to the Health System.
             */
            
            Destroy(other.gameObject);
            
            SoundFXManager._SingleInstance.InvaderExplosionSFXPlay();
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
