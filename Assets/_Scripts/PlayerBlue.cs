using UnityEngine;
using System.Collections;

public class PlayerBlue : MonoBehaviour 
{
	void OnMouseDown() 
	{
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_PAPER);
		Application.LoadLevel("MainScene");
	}
}
