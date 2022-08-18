using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Projectile : MonoBehaviour
{
    [SerializeField]private float projectileSpeed;
    private Vector3 direction = Vector3.up;
    private System.Action<Projectile> destroyed;

    private void OnDestroy() {
        if(destroyed != null){
            destroyed.Invoke(this);
        }
    }    

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * projectileSpeed * Time.deltaTime;
    }
    
    private void CheckCollision(Collider2D other) {
        if (other.CompareTag("Enemy")){
            Destroy(gameObject);
            Debug.Log("Detected!" + other);
        }     
        if (other.CompareTag("Player")){
            Destroy(gameObject);
            Debug.Log("Detected!" + other);
        }   
    }

    private void OnTriggerEnter2D(Collider2D other) {
        CheckCollision(other);    
    }
}
