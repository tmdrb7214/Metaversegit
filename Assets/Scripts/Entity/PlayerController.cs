using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera camera;
    public float jumpForce = 7f;
    private bool isGrounded;
    private Transform playertransform;
    protected override void Start()
    {
        base.Start();
        camera = Camera.main;
        playertransform = transform;
    }

    protected override void HandleAction()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movementDirection = new Vector2(horizontal, vertical).normalized;

        if(movementDirection.x > 0.5f)
        {
            playertransform.localScale = new Vector3(1, 1, 1);
        }
        else if (movementDirection.x < 0.5f)
        {
            playertransform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
        }
    }

}
