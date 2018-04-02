using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {


	public GameObject rocks; 


	//public GameObject rocket_enemy;
	// Use this for initialization
	//public int score =0;
	void Start () {
		InvokeRepeating("CreateObstacle",1f,1.5f);
	
		//InvokeRepeating("CreateObstacle2",9.7f,1.5f);
		
	}
	
	// Update is called once per frame
	void Update () {



	}




	void CreateObstacle()
	{
		Instantiate(rocks);


		//score++;
		//return score;
	}

}
