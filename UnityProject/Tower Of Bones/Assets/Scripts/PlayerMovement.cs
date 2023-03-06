using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask JumpableGround;
    [SerializeField] private Transform startAttack;
    [SerializeField] private List<GameObject> damageZones;

    public int jumpHeight = 15;
    public int moveSpeed = 7;
    private bool doubleJump = false;
    private bool hasHead = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();

        GetComponent<Health>().onDeath += OnDeath;
    }

    private void Update()
    {
        // i know that this is using the input manager not system but idc
        float dirX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            doubleJump = true;
            rb.velocity = Vector2.up * jumpHeight;
        }
        else if(Input.GetButtonDown("Jump") && doubleJump) 
        { 
            doubleJump = false;
            rb.velocity = Vector2.up * (jumpHeight / 1.5f);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(damageZones[0], startAttack.position, Quaternion.identity);
		}
        if (Input.GetButtonDown("Fire2") && hasHead)
        {
            Instantiate(damageZones[1], startAttack.position, Quaternion.identity);
			FindObjectOfType<GameManager>().AddScore(0.01f);
            hasHead = false;
		}
        if(dirX < 0) 
        {
            GetComponent<SpriteRenderer>().flipX = true;
            startAttack.transform.localPosition = Vector2.right * -0.655f;
		}
		if (dirX > 0)
		{
			GetComponent<SpriteRenderer>().flipX = false;
            startAttack.transform.localPosition = Vector2.right * 0.655f;
		}
		rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        //Debug.DrawRay(coll.bounds.center, Vector2.down, Color.red);
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, JumpableGround);
    }

    private void OnDeath()
    { 
        // 
    }

    public void HasHead()
    {
		hasHead = true;
	}

    public bool LookingRight()
    {
        return GetComponent<SpriteRenderer>().flipX == false;
    }
}
