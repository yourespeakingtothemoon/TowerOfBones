using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask JumpableGround;

    public int jumpHeight = 15;
    public int moveSpeed = 7;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        // i know that this is using the input manager not system but idc
        if (Input.GetButtonDown("Jump") && IsGrounded())
        { 
            rb.velocity = Vector2.up * jumpHeight;
        }
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    private bool IsGrounded()
    { 
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, JumpableGround);
    }
}
