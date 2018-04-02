using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class game_Controller : MonoBehaviour {

	// Use this for initialization
	public Canvas pauseMenu;
	public Button pauseText;

	void Start () {
	
		pauseMenu = pauseMenu.GetComponent<Canvas>();
		
		pauseText =pauseText.GetComponent<Button>();

		pauseMenu.enabled=false;
	}


	public void PausePress()
	{
		pauseMenu.enabled=true;
		pauseText.enabled=false;
		Time.timeScale = 0f; 
	}

	public void ResumePress()
	{
		pauseMenu.enabled=false;
		pauseText.enabled=true;
		Time.timeScale = 1f; 
	}
	// Update is called once per frame
	void Update () {
	
	}
}
