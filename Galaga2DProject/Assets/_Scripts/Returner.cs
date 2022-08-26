using UnityEngine;

public class Returner : Singleton<Returner>
{
    private void OnTriggerEnter2D(Collider2D other) {
        ObjectPooler._SingleInstance.ReturnToPool(other.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if ((!other.gameObject.tag.Equals("Player") || (!other.gameObject.tag.Equals("Enemy"))))
        {
            ObjectPooler._SingleInstance.ReturnToPool(other.gameObject);
        }
    }
}
