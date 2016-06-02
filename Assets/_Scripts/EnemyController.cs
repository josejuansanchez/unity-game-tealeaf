using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour 
{
	public float speed = 3f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Translate (Vector2.left * Time.deltaTime * speed);
	}
}
