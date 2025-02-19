using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int isMoving = Animator.StringToHash("IsMove");
    

    protected Animator animator;
    private Rigidbody2D _rigidbody;
    private bool isGrounded;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move(_rigidbody.velocity);
    }
   
    public void Move(Vector2 obj)
    {
        animator.SetBool(isMoving, obj.magnitude >.5f);
    }

}
