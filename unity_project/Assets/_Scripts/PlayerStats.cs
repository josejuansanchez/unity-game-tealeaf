using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour 
{
	public int playerType;
	public Sprite[] avatars;
	public SpriteRenderer playerAvatar;

	void Start () 
	{
		// Get the playerType form the static class
		playerType = ScenesParameters.GetParameter ("playerType");

		// Sets character avatar
		playerAvatar.sprite = avatars [playerType];
	}
}