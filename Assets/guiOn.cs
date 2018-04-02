using UnityEngine;
using System.Collections;

//using Facebook.Unity;
public class guiOn : MonoBehaviour {

	// Use this for initialization
	//public GUISkin newSKIN;

	/*void Awake()
	{
		FB.Init (SetInit,onHideUnity);
	}


	private void SetInit()
	{

		Debug.Log("FB init done.");
		if(FB.IsLoggedIn){
			Debug.Log ("FB logged in");
		}else{
			FBlogin();
		}

	}

	private void onHideUnity(bool isGameShown)
	{
		if(!isGameShown){
			Time.timeScale = 0;
		}else{
			Time.timeScale = 1;
			
		}
	}


	void FBlogin()
	{
		var permissions = new string[] {"public_profile", "email", "user_friends"};
		FB.LogInWithReadPermissions(permissions,AuthCallback);

		
	}

	void AuthCallback(IResult result){

		if(FB.IsLoggedIn){
			Debug.Log ("It's Works");
		}else{
			Debug.Log("Fail");
		}
	}*/


	void Start () {

	}




	
	// Update is called once per frame
	void Update () {
	
	}
	/*void OnGUI()
	{
		GUI.skin=newSKIN;
		if(GUI.Button(new Rect (Screen.width/2-50, Screen.height/2-50, 200, 50), "START")) {
			Application.LoadLevel("level1");
		}

		if(GUI.Button(new Rect (Screen.width/2-50, Screen.height/2+10, 200, 50), "QUIT")) {
			Application.Quit();
		}
		GUI.Label(new Rect (Screen.width/2-50, Screen.height/2-100, 200, 50), "Infinity");
		//.Label(new Rect (Screen.width/2-50, Screen.height/2-100, 200, 50), "");

	}*/







	public void Level2Start(){
		Application.LoadLevel("level2");
	}

	public void Quit(){
		Application.Quit();
	}


}
