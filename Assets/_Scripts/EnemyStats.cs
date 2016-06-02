using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour 
{
	public Sprite[] avatarsForGlass;
	public Sprite[] avatarsForOrganic;
	public Sprite[] avatarsForPaper;
	public Sprite[] avatarsForPlastic;
	public SpriteRenderer enemyAvatar;

	void Start () 
	{
		int index;
		int enemyType = Random.Range (0, 4);

		// Sets character avatar
		switch (enemyType) 
		{
		case 0:
			index = Random.Range (0, avatarsForGlass.Length);
			enemyAvatar.sprite = avatarsForGlass [index];
			break;
		case 1:
			index = Random.Range (0, avatarsForOrganic.Length);
			enemyAvatar.sprite = avatarsForOrganic [index];
			break;
		case 2:
			index = Random.Range (0, avatarsForPaper.Length);
			enemyAvatar.sprite = avatarsForPaper [index];
			break;
		case 3:
			index = Random.Range (0, avatarsForPlastic.Length);
			enemyAvatar.sprite = avatarsForPlastic [index];
			break;
		}			
	}
}