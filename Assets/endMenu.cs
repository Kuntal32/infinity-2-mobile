using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class endMenu : MonoBehaviour {

	// Use this for initialization
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	public Text txt;

	public Text point;
	private int currentscore=0;

	private int points=0;



	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas>();
		
		startText =startText.GetComponent<Button>();
		
		exitText = exitText.GetComponent<Button>();
		quitMenu.enabled=false;

		currentscore = PlayerPrefs.GetInt("Score");

		points=PlayerPrefs.GetInt("Points");
		//Debug.Log(currentscore);
		txt.text="Score : " + currentscore;
		point.text="Points : " + points;
	}

	void Update () {
		txt.text="Score : " + currentscore;  
		point.text="Points : " + points;
		PlayerPrefs.SetInt("Points",points); 
		PlayerPrefs.SetInt("Score",currentscore); 
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