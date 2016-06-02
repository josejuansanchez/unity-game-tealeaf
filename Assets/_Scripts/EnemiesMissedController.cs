using UnityEngine;
using System.Collections;

public class EnemiesMissedController : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log (collider.gameObject.name);

		EnemyStats enemyStats = collider.gameObject.transform.parent.GetComponent<EnemyStats> ();

		// Jumped enemy
		// enemyStats.enemyType

		Destroy (collider.gameObject.transform.parent.gameObject);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log (col.gameObject.name);
		Destroy (col.gameObject.transform.parent.gameObject);
		//Destroy (col.gameObject);
	}

}
