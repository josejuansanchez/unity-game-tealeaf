using UnityEngine;
using System.Collections;

public class PlayerGray : MonoBehaviour 
{
	void OnMouseDown() 
	{
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_ORGANIC);
		Application.LoadLevel("MainScene");
	}
}
