using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gui : MonoBehaviour {

	// Use this for initialization

	//public Text sometext;
	
	// Update is called once per frame

	public Text txt;
	private int currentscore=0;
	
	// Use this for initialization
	void Start () {
		//txt = gameObject.GetComponent<Text>(); 
		currentscore = PlayerPrefs.GetInt("Score");
		//Debug.Log(currentscore);
		txt.text="Score : " + currentscore;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text="Score : " + currentscore;  
		 

		PlayerPrefs.SetInt("Score",currentscore); 
	}




	/*void OnGUI()
	{
		GUI.skin=newSKIN;
		if(GUI.Button(new Rect (Screen.width/2-50, Screen.height/2-50, 200, 50), "RESTART")) {
			Application.LoadLevel("level1");
		}
		
		if(GUI.Button(new Rect (Screen.width/2-50, Screen.height/2+10, 200, 50), "QUIT")) {
			Application.Quit();
		}
		//score=gameObject.GetComponent<Generate>().scores;
		GUI.Label(new Rect (Screen.width/2-50, Screen.height/2-100, 200, 50), "GAME OVER");

		//GUI.Label(new Rect (Screen.width/2-50, Screen.height/2-100, 200, 50), "SCORE"+ score.ToString());



		
		// do we have a GUIText?
		//GUIText guiText=GetComponent&lt;
		//GUIText&gt;();

	}*/



	public void PlayAgain(){
		Application.LoadLevel("level2");


	}

	public void PlayAgainLevel1(){
		Application.LoadLevel("level1");
		
		
	}

	public void mainMenu(){
		Application.LoadLevel("mainMenu");
		
		
	}
	
	public void Quit(){
		Application.Quit();
	}



}
