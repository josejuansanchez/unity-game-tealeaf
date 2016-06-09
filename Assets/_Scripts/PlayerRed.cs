using UnityEngine;
using System.Collections;

public class PlayerRed : MonoBehaviour 
{
	void OnMouseDown() 
	{
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_DANGEROUS);
		Application.LoadLevel("MainScene");
	}
}
