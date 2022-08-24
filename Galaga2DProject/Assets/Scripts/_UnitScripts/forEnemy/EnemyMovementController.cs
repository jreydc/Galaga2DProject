using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour, IMovementManager
{
    [SerializeField]private Player thePlayer;
    
    [SerializeField]private float scale;
    [SerializeField]private float speed;
    [SerializeField]private float maxDistance;
    [SerializeField]private float time2Move;
    
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<Player>();
    }
    
    private void FixedUpdate() {
        if (thePlayer.transform.position.y <= transform.position.y)
        {
            Flip(1);
        }
        else
        {
            Flip(-1);
        }
    }

    public bool IsMoving{
        get{return isMoving;}
    } 

    public void UnitMovementDirection(){
        time2Move += Time.deltaTime;
        if(time2Move >= 10f) isMoving = true;
        if (((transform.position.x - thePlayer.transform.position.x) <= maxDistance) && (isMoving))
            UnitMovementComputations(speed);
    }

    public void UnitMovementComputations(float moveSpeed){
        transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, speed * Time.deltaTime);
    }

    private void Flip(float i){
        transform.localScale = new Vector3(scale, scale * i, scale);
    }
}
