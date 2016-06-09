using UnityEngine;
using System.Collections;

public class PlayerGreen : MonoBehaviour 
{
	void OnMouseDown() 
	{
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_GLASS);
		Application.LoadLevel("MainScene");
	}
}
