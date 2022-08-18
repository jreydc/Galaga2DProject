public interface IAnimator 
{
    void ChangeAnimationState(string newState);
    void PlayerAttack();
    void PlayerMoving();
    void PlayerIdle();
}
