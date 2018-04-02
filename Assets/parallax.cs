using UnityEngine;
using System.Collections;

public class parallax : MonoBehaviour {


	public Transform[] backgrounds;

	private float[] parallaxScales;

	public float smooting = 1f;

	private Transform cam;

	private Vector3 previousCamPosition;
	// Use this for initialization

	void Awake(){

		cam = Camera.main.transform;


	}

	void Start () {
		previousCamPosition = cam.position;

		parallaxScales = new float[backgrounds.Length];

		for(int i = 0; i < backgrounds.Length; i++)
		{
			parallaxScales[i] = backgrounds[i].position.z * -1;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
		for(int i = 0; i < backgrounds.Length; i++)
		{
			float parallax = previousCamPosition.x - cam.position.x * parallaxScales[i];

			float backgroundTargetPosX = backgrounds[i].position.x + parallax;

			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX,backgrounds[i].position.y,backgrounds[i].position.z);

			backgrounds[i].position = Vector3.Lerp(backgrounds[i].position,backgroundTargetPos,smooting * Time.deltaTime);

		}
		previousCamPosition = cam.position;


	}
}
