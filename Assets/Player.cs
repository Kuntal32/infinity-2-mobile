using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 jumpForce=new Vector2(0,300);
	public RuntimePlatform platform;
	public int score=0;
	public GameObject cust;
	private Rigidbody2D rigi;
	public int point=0;
	private bool objType;

	// Use this for initialization
    

	public GUISkin newskin;

	private void Awake()
	{
		rigi = GetComponent<Rigidbody2D>();
	}


	void Start () {
	
	}
	
	// Update is called once per frame



	void Update () {

		PlayerPrefs.SetInt("Score",score);
		PlayerPrefs.SetInt("Points",point);
		if(Input.touchCount > 0) {
			for(int i=0; i < Input.touchCount; i++){
			if(Input.GetTouch(i).phase == TouchPhase.Began){
				//Debug.Log ("yy");


					rigi.velocity=Vector2.zero;
					rigi.AddForce(jumpForce);

			}
			}
		}
		//}

		if(Input.GetKeyUp("space")){

			rigi.velocity=Vector2.zero;
			rigi.AddForce(jumpForce);
		}

		Vector2 scrinPosition=Camera.main.WorldToScreenPoint(transform.position);
	
			if( scrinPosition.y<0){
			//StartCoroutine("Die");
			//Die ();

			if(gameObject.name=="player2")
			{
				objType=false;


				Application.LoadLevel("endMenu");
			}

			Destroy(gameObject);

			//Application.LoadLevel("end");
		}


	}


	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.name=="cust"){
			
			
			score ++;
			PlayerPrefs.SetInt("Score",score);
		}

		if(other.gameObject.tag=="star1"){
			
			point=point+100;
			PlayerPrefs.SetInt("Points",point);
		}

		if(other.gameObject.tag=="star2"){
			
			point=point+200;
			PlayerPrefs.SetInt("Points",point);
		}

		if(other.gameObject.tag=="star5"){
			
			point=point+500;
			PlayerPrefs.SetInt("Points",point);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag=="top"){

		}else{
			GetComponent<AudioSource>().Play ();

			if(gameObject.name=="player2")
			{


				//Handheld.Vibrate();
				objType=false;
			}

			StartCoroutine("Die");
		}

	}

	void OnGUI () 
	{
		GUI.color = Color.white;
		GUI.skin=newskin;
		
		//GUI.Label(new Rect (Screen.width/2-50, Screen.height/2-100, 200, 50), " Score: " + score.ToString());
		GUI.Label (new Rect(0,Screen.height-35,200,50), " Score: " + score.ToString());
		GUI.Label (new Rect(Screen.width - 200,Screen.height-35,200,50), " Points: " + point.ToString());
	}
	//void OnColliderEnter2D(Collider2D col)
	//{
	//	if(col.tag=="rockUp")
	//	{
	//		Debug.Log("hello");
	//	}
	//}

	public IEnumerator Die()
	{

		//yield WaitForSeconds(5.0);  // or however long you want it to wait
		yield return new WaitForSeconds(1);

		if(objType==false){

			Application.LoadLevel("endMenu");
		}
		Destroy(gameObject);
	}

}
