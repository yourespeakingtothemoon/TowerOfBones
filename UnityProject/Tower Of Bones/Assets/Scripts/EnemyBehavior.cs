using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBehavior : MonoBehaviour
{
	private Rigidbody2D rb;
	private bool goingLeft = true;

	[SerializeField] private float speed;

	public void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		GetComponent<Health>().onDeath += OnDeath;
	}

	private void Update()
	{
		if (goingLeft)
		{
			rb.velocity = Vector2.left * speed;
		}
		else 
		{
			rb.velocity = Vector2.right * speed;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Ledge"))
		{
			goingLeft = goingLeft == true ? false : true;
		}
	}

	private void OnDeath()
	{
		FindObjectOfType<GameManager>().AddScore(Random.Range(0.5f, 1.5f));
		Destroy(gameObject);
	}

}
