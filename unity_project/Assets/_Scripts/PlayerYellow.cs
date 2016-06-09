using UnityEngine;
using System.Collections;

public class PlayerYellow : MonoBehaviour 
{
	void OnMouseDown() 
	{
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_PLASTIC);
		Application.LoadLevel("MainScene");
	}
}
