using UnityEngine;
using System.Collections;

public class LifesController : MonoBehaviour {

	public SpriteRenderer life1;
	public SpriteRenderer life2;
	public SpriteRenderer life3;
	public Sprite[] avatars;
	int numberOfLifes = 3;

	// Use this for initialization
	void Start () 
	{
		// Get the playerType form the static class
		int playerType = ScenesParameters.GetParameter ("playerType");

		// Set the avatar
		life1.sprite = avatars [playerType];
		life2.sprite = avatars [playerType];
		life3.sprite = avatars [playerType];
	}

	public void HideLifeAvatar() 
	{
		// Destoy the avatar
		if (numberOfLifes == 3) 
		{
			Destroy (life3);
		} 
		else if (numberOfLifes == 2) 
		{
			Destroy (life2);
		} 
		else 
		{
			Destroy (life1);
		}
	}

	public void DecrementLifes() 
	{
		numberOfLifes--;
	}

	public int GetNumberOfLifes() 
	{
		return numberOfLifes;
	}
}
