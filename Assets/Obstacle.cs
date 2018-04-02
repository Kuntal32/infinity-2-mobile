using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	public Vector2 velocity=new Vector2(-6,0);
	public float range=4;
	private Rigidbody2D rigi;
	private void Awake()
	{
		rigi = GetComponent<Rigidbody2D>();
	}
	void Start () {
	
		rigi.velocity=velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	
	}


	
	// Update is called once per frame
	void Update () {
		//Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		//Debug.Log (screenPosition.x);
		//if (screenPosition.x > Screen.width || screenPosition.x > 331)
			//Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.name=="leftWall"){
			
			//Debug.Log ("sds");
			Destroy(gameObject);
		}
	}


}
