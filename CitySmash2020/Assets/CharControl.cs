using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
	private Rigidbody2D ridgidBody;
	public bool hit;

	// Start is called before the first frame update
	void Start()
    {
		ridgidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		var horz = Input.GetAxis("Horizontal");
		ridgidBody.velocity = new Vector2(horz * 10, ridgidBody.velocity.y);
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		hit = true;
	}
}
