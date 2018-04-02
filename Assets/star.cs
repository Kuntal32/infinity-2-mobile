using UnityEngine;
using System.Collections;

public class star : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 2f, 0f);
	}


	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag=="Player"){
			
			//Debug.Log ("sds");
			Destroy(gameObject);
		}
	}

	

}
