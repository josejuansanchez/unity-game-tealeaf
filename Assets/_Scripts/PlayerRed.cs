using UnityEngine;
using System.Collections;

public class PlayerRed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_DANGEROUS);
		Application.LoadLevel("MainScene");
	}
}
