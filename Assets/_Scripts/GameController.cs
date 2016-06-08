using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Transform scoreText;
	//public GUIText scoreText;
	public int score;

	// Use this for initialization
	 void Start () {
		score = 0;
		UpdateScore ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;	
		UpdateScore ();
	}

	void UpdateScore() 
	{
		//scoreText.text = "Score: " + score;
		scoreText.GetChild (0).GetComponent<GUIText> ().text = "Score: " + score;
		scoreText.GetChild (1).GetComponent<GUIText> ().text = "Score: " + score;
	}
}
