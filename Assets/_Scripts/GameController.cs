using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public LifesController lifesController;
	public Transform scoreText;
	public Transform playerName;
	public Transform gameOverText;
	public AudioSource audio;
	public AudioClip winSound;
	public AudioClip gameOverSound;

	private const int MAX_SCORE = 5;
	private int score;
	private bool gameOver;

	// Use this for initialization
	void Start () 
	{
		gameOver = false;
		score = 0;
		UpdateScore ();
		DisplayPlayerName ();
		audio = GetComponent<AudioSource> ();
	}

	void Update() 
	{
		if (score == MAX_SCORE && !gameOver) 
		{
			GameOver ("Well done! :)", winSound);
		}

		if (lifesController.GetNumberOfLifes () == 0 && !gameOver) 
		{
			GameOver ("Game Over :(", gameOverSound);
		}

		if (gameOver) 
		{
			if(Input.touchCount == 1)
			{
				Application.LoadLevel("SplashScene");
			}

			if (Input.GetMouseButtonDown (0)) 
			{
				Application.LoadLevel("SplashScene");
			}		
		}

		if (Input.GetKeyDown(KeyCode.Escape)) 
		{ 
			Application.LoadLevel("SelectPlayerScene");
		}
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;	
		UpdateScore ();

		if (newScoreValue < 0) 
		{
			lifesController.HideLifeAvatar ();
			lifesController.DecrementLifes ();
		}
	}

	void UpdateScore() 
	{
		scoreText.GetChild (0).GetComponent<GUIText> ().text = "Score: " + score;
		scoreText.GetChild (1).GetComponent<GUIText> ().text = "Score: " + score;
	}
		
	void DisplayPlayerName() 
	{
		string name = "";

		switch (ScenesParameters.GetParameter ("playerType")) 
		{
			case PlayerTypes.PLAYER_TYPE_GLASS:
				name = "Glass";
				break;
			case PlayerTypes.PLAYER_TYPE_ORGANIC:
				name = "Organic";
				break;
			case PlayerTypes.PLAYER_TYPE_PAPER:
				name = "Paper";
				break;
			case PlayerTypes.PLAYER_TYPE_PLASTIC:
				name = "Plastic";
				break;
			case PlayerTypes.PLAYER_TYPE_DANGEROUS:
				name = "Dangerous";
				break;
		}

		playerName.GetChild (0).GetComponent<GUIText> ().text = name;
		playerName.GetChild (1).GetComponent<GUIText> ().text = name;
	}


	public void GameOver (string text, AudioClip clip)
	{
		gameOver = true;

		gameOverText.GetChild (0).GetComponent<GUIText> ().text = text;
		gameOverText.GetChild (1).GetComponent<GUIText> ().text = text;

		audio.Stop ();
		audio.PlayOneShot (clip, 0.5f);

		Destroy (GameObject.Find ("Player"));
		Destroy (GameObject.Find ("EnemiesController"));
	}
}
