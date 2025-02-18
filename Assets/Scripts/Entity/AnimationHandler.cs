using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int isMoving = Animator.StringToHash("IsMove");
    private static readonly int isLooking = Animator.StringToHash("Jump");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetBool(isMoving, obj.magnitude >.5f);
    }


}
