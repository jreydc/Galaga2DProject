using UnityEngine;

public class PlayerProjectile : Projectile
{
    public override void OnDestroy() {
        base.OnDestroy();
    }
    public override void CheckCollision(Collider2D other)
    {
        if (other.tag == "Enemy"){
            ObjectPooler._SingleInstance.ReturnToPool(other.gameObject);
            SoundFXManager._SingleInstance.InvaderExplosionSFXPlay();
            VFXManager._SingleInstance.InvaderVFXExplosionPlay(other.gameObject.transform.position);
        }
        base.CheckCollision(other);
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
