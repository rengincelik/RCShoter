using UnityEngine;


public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    void Update()
    {
        animator.SetBool("IsWalking", rb.linearVelocity.sqrMagnitude > 0.0001f);
    }
}
