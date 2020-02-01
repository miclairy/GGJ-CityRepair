using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
	private Rigidbody2D ridgidBody;

	// Start is called before the first frame update
	void Start()
	{
		ridgidBody = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{
		// ridgidBody.velocity = new Vector2(10, ridgidBody.velocity.y);
	}
}
