﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class mainMmenu : MonoBehaviour {

	// Use this for initialization
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;





	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas>();

		startText =startText.GetComponent<Button>();

		exitText = exitText.GetComponent<Button>();
		quitMenu.enabled=false;

	}

	public void ExitPress()
	{
		quitMenu.enabled=true;
		startText.enabled=false;
		exitText.enabled=false;
	}

	public void NoPress()
	{
		quitMenu.enabled=false;
		startText.enabled=true;
		exitText.enabled=true;
	}


	public void StartGame(){
		Application.LoadLevel("level2");
		

	}

	public void Quit(){
		Application.Quit();

	}
}
