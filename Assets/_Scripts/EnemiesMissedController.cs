using UnityEngine;
using System.Collections;

public class EnemiesMissedController : MonoBehaviour 
{
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.name == "EnemyAvatar") {

			// TODO
			EnemyStats enemyStats = col.gameObject.transform.parent.GetComponent<EnemyStats> ();
			Debug.Log ("enemyStats.isEnemy: " + enemyStats.isEnemy);

			Destroy (col.gameObject.transform.parent.gameObject);
		}
	}

}
