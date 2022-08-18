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
    private bool moveTowardsDPlayer;

    // Start is called before the first frame update
    void Start()
    {
        unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
        thePlayer = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    private void Update()
    {
        time2Move += Time.deltaTime;
        if(time2Move >= 10f){
            unitAnim82r.PlayerMoving();
            moveTowardsDPlayer = true;
        }
    }

    private void FixedUpdate() {
        if (((transform.position.x - thePlayer.transform.position.x) <= maxDistance) && (moveTowardsDPlayer))
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, speed * Time.deltaTime);
        
        if (thePlayer.transform.position.x < transform.position.x)
        {
            Flip(-1);
        }
        else
        {
            Flip(1);
        }
    }

    private void Flip(float i){
        transform.localScale = new Vector3(scale * i, scale, scale);
    }
}
