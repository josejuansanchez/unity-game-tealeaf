using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour 
{
	public Transform subtitle;
	int increment = 1;

	// Update is called once per frame
	void Update () 
	{
		OnTouchScreen();
		AnimateSubtitle();

		if (Input.GetKeyDown(KeyCode.Escape)) 
		{ 
			Application.Quit();
		}
	}

	void AnimateSubtitle() 
	{
		if (subtitle.GetChild (0).GetComponent<GUIText> ().fontSize > 70) 
		{
			increment = -1;
		} 

		if (subtitle.GetChild (0).GetComponent<GUIText> ().fontSize < 62) 
		{
			increment = 1;
		}

		subtitle.GetChild (0).GetComponent<GUIText> ().fontSize += increment;
		subtitle.GetChild (1).GetComponent<GUIText> ().fontSize += increment;
	}

	void OnTouchScreen() 
	{
		if(Input.touchCount == 1)
		{
			Application.LoadLevel("SelectPlayerScene");
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			Application.LoadLevel("SelectPlayerScene");
		}
	}
}