using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera camera;
    public float jumpForce = 2f;
    private bool isGrounded;
    private Transform playertransform;
    public LayerMask groundLayer;
    protected override void Start()
    {
        base.Start();
        camera = Camera.main;
        playertransform = transform;
    }

    protected override void HandleAction()
    {
        CheckGround();
        if (!isGrounded) return;

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
            isGrounded = false;
        }
    }
    private void FixedUpdate()
    {
        if (isGrounded)
        {
            _rigidbody.velocity = new Vector2(movementDirection.x * 5, _rigidbody.velocity.y);
        }
        else
        {
            _rigidbody.velocity += Vector2.down * 10f *Time.deltaTime;
        }
    }

    private void CheckGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.1f , groundLayer);
        isGrounded = hit.collider != null;

    }

}
