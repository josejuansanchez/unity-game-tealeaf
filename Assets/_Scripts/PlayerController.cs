using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	bool isJumping = false;
	float gravity = 4f;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space) && !isJumping) 
		{
 			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
			isJumping = true;
		}
			
		// To do the jump faster
		if (isJumping) 
		{
			Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
			velocity.y -= gravity * Time.deltaTime;
			GetComponent<Rigidbody2D>().velocity = velocity;
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.name == "Ground") {
			isJumping = false;
		} else {
			//Destroy (col.gameObject);
			Destroy (col.gameObject.transform.parent.gameObject);

			// Trick to make that the player reach the ground slowly
			// while the object is destroyed
			Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
			velocity.y = -1 * Time.deltaTime;
			GetComponent<Rigidbody2D>().velocity = velocity;
		}
	}
}
