using UnityEngine;

public class EnemyAnimatorController : MonoBehaviour
{
    Animator animator;
    private string currentState;

    // Animation States
    const string IDLE = "idle";
    const string ATTACK01 = "attack01";
    const string GETHIT = "GetHit";
    const string WALK = "walk";
    const string DIE = "die";


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }

    public void Idle()
    {
        ChangeAnimationState(IDLE);
    }

    public void Attack01()
    {
        ChangeAnimationState(ATTACK01);
    }

    public void GetHit()
    {
        ChangeAnimationState(GETHIT);
    }

    public void Walk()
    {
        ChangeAnimationState(WALK);
    }

    public void Die()
    {
        ChangeAnimationState(DIE);
    }
}
