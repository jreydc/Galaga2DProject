using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Projectile : MonoBehaviour, ICollisionManager
{
    [SerializeField]public float projectileSpeed;
    public Vector3 direction = Vector3.up;
    public System.Action<Projectile> IsDestroyed;

    public virtual void OnDestroy() {
        if(IsDestroyed != null){
            IsDestroyed?.Invoke(this);
        }
    }    

    public virtual void OnEnable(){
        //Debug.Log("Projectile is Spawned!");
    }

    public virtual void ProjectileMovement()
    {
        transform.position += direction * projectileSpeed * Time.deltaTime;
    }
    
    public virtual void CheckCollision(Collider2D other) {
        ObjectPooler._SingleInstance.ReturnToPool(gameObject);
    }

}
