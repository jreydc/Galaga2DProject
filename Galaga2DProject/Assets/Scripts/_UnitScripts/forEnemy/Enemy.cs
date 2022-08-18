using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class Enemy : Unit
{
    private UnitAnimator unitAnim82r;
    [SerializeField]private float time2Move;

    // Start is called before the first frame update
    void Start()
    {
        unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
    }

    // Update is called once per frame
    void Update()
    {
        time2Move += Time.deltaTime;
        if(time2Move >= 10f){
            unitAnim82r.PlayerMoving();
        }
    }
}
