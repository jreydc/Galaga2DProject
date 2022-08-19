using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Projectile : MonoBehaviour, ICollisionManager
{
    [SerializeField]public LayerMask layerMask;
    [SerializeField]public float projectileSpeed;
    public Vector3 direction = Vector3.up;
    public System.Action<Projectile> destroyed;

    public virtual void OnDestroy() {
        if(destroyed != null){
            destroyed.Invoke(this);
        }
    }    

    // Update is called once per frame
    public void ProjectileMovement()
    {
        transform.position += direction * projectileSpeed * Time.deltaTime;
    }
    
    public virtual void CheckCollision(Collider2D other) {
        Debug.Log("Detected!" + other);
        
        /* if (other.CompareTag("Player") && !this.gameObject.tag.Equals("Player")){
            Destroy(gameObject);
            Debug.Log("Detected!" + other);
        }   */ 
    }

}
