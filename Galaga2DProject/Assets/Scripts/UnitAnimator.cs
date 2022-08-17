using UnityEngine;
[RequireComponent(typeof(Animator))]
public class UnitAnimator : MonoBehaviour
{
    const string PLAYER_IDLE = "Idle";
    const string PLAYER_ATTACK = "Attack";
    const string PLAYER_MOVING = "Moving";
    
    private float xAxis;
    private float yAxis;
    private float attackDelay = 0.3f;

    private Animator anime2r;
    private string currentAnime2RState;

    private void Awake() {
        anime2r = GetComponent<Animator>();
    }

    public void ChangeAnimationState(string newState){
        //stop the same animation from interrupting itself
        if (currentAnime2RState == newState) return;

        //play the animation
        anime2r.Play(stateName: newState);

        currentAnime2RState = newState;
    }

    public void PlayerAttack(){
        attackDelay = anime2r.GetCurrentAnimatorStateInfo(0).length;
        Invoke("AttackComplete2Idle", attackDelay);
    }

    public void PlayerMoving(){
        ChangeAnimationState(PLAYER_MOVING);
        attackDelay = anime2r.GetCurrentAnimatorStateInfo(0).length;
        //Invoke("AttackComplete2Idle", attackDelay);
    }

    
    public void PlayerIdle(){
        ChangeAnimationState(PLAYER_IDLE);
    }
}
