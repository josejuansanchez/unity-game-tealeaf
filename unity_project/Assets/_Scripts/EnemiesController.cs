using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemiesController : MonoBehaviour 
{
	public GameObject[] enemiesPrefabs;
	public float enemyCreationTime = 1.5f;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("CreateEnemy", 0f, enemyCreationTime);
	}

	void CreateEnemy() 
	{
		GameObject enemy = Instantiate (enemiesPrefabs [Random.Range(0, enemiesPrefabs.Length-1)], 
			gameObject.transform.position, Quaternion.identity) as GameObject;
	}
}
