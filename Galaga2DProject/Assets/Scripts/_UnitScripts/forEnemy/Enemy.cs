using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class Enemy : Unit
{
    private UnitAnimator unitAnim82r;
    [SerializeField]private Player thePlayer;
    [SerializeField]private float scale;
    [SerializeField]private float speed;
    [SerializeField]private float maxDistance;
    [SerializeField]private float time2Move;
    [SerializeField]private float time2Attack;
    private bool moveTowardsDPlayer;

    //Initializations for Projectiles
    [SerializeField]private Transform projectileSpawner;
    [SerializeField]private GameObject projectile;



    // Start is called before the first frame update
    void Start()
    {
        unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
        thePlayer = FindObjectOfType<Player>();
        projectileSpawner = transform.GetChild(3).gameObject.transform;
    }

    // Update is called once per frame
    private void Update()
    {
        time2Move += Time.deltaTime;
        time2Attack += Time.deltaTime;
        if(time2Move >= 10f){
            unitAnim82r.PlayerMoving();
            moveTowardsDPlayer = true;
        }

        if(time2Attack >= 0.5f){
            Shoot();
            time2Attack = 0f;
        }
    }

    private void FixedUpdate() {
        if (((transform.position.x - thePlayer.transform.position.x) <= maxDistance) && (moveTowardsDPlayer))
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, speed * Time.deltaTime);
        
        if (thePlayer.transform.position.y <= transform.position.y)
        {
            Flip(1);
        }
        else
        {
            Flip(-1);
        }
    }

    private void Flip(float i){
        transform.localScale = new Vector3(scale, scale * i, scale);
    }

    private void Shoot(){
        Instantiate(projectile, projectileSpawner.position, Quaternion.identity);
    }
}
