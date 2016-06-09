using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour 
{
	public Sprite[] avatarsForGlass;
	public Sprite[] avatarsForOrganic;
	public Sprite[] avatarsForPaper;
	public Sprite[] avatarsForPlastic;
	public Sprite[] avatarsForDangerous;
	public SpriteRenderer enemyAvatar;
	public bool isEnemy = true;

	void Start () 
	{
		int index;
		int enemyType = Random.Range (0, 5);

		// Sets character avatar
		switch (enemyType) 
		{
			case PlayerTypes.PLAYER_TYPE_GLASS:
				index = Random.Range (0, avatarsForGlass.Length);
				enemyAvatar.sprite = avatarsForGlass [index];
				break;
			case PlayerTypes.PLAYER_TYPE_ORGANIC:
				index = Random.Range (0, avatarsForOrganic.Length);
				enemyAvatar.sprite = avatarsForOrganic [index];
				break;
			case PlayerTypes.PLAYER_TYPE_PAPER:
				index = Random.Range (0, avatarsForPaper.Length);
				enemyAvatar.sprite = avatarsForPaper [index];
				break;
			case PlayerTypes.PLAYER_TYPE_PLASTIC:
				index = Random.Range (0, avatarsForPlastic.Length);
				enemyAvatar.sprite = avatarsForPlastic [index];
				break;
			case PlayerTypes.PLAYER_TYPE_DANGEROUS:
				index = Random.Range (0, avatarsForDangerous.Length);
				enemyAvatar.sprite = avatarsForDangerous [index];
				break;
		}
			
		// Check if the created object should be a enemy
		if (GameObject.Find("Player").GetComponent<PlayerStats>().playerType == enemyType) 
		{
			isEnemy = false;
		}

	}
}