using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour 
{
	public int playerType;
	public Sprite[] avatars;
	public SpriteRenderer playerAvatar;

	void Start () 
	{
		// Sets character avatar
		playerAvatar.sprite = avatars [playerType];
	}

	public void ScoreSuccess()
	{
		Debug.LogError ("Score!");
	}

	public void ScoreFail()
	{
		Debug.LogError ("Fail!");
	}
}
