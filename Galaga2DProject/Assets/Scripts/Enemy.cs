using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{
    private UnitAnimator unitAnim82r;
    [SerializeField]private float time2Move = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time2Move += Time.deltaTime;
        if(time2Move >= 5f){
            unitAnim82r.PlayerMoving();
        }else{
            unitAnim82r.PlayerIdle();
            time2Move = 0f;
        }
        
    }
}
