using UnityEngine;
using System.Collections;

public class EnemiesMissedController : MonoBehaviour 
{
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.name == "EnemyAvatar") 
		{
			Destroy (col.gameObject.transform.parent.gameObject);
		}
	}
}
