using UnityEngine;
using System.Collections;

public class PlayerGray : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown() {
		ScenesParameters.SetParameter ("playerType", PlayerTypes.PLAYER_TYPE_ORGANIC);
		Application.LoadLevel("MainScene");
	}
}
