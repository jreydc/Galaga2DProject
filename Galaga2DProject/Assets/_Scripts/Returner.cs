using UnityEngine;

public class Returner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        //ObjectPooler._SingleInstance.ReturnToPool(other.gameObject);
        Debug.Log(other.tag);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if ((other.gameObject.tag != "Player") || (other.gameObject.tag != "Enemy"))
        {
            //ObjectPooler._SingleInstance.ReturnToPool(other.gameObject);
        }
        Debug.Log("On Collision" + other.gameObject.tag);
    }
}
