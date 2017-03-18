using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPlayerControllerSP : MonoBehaviour {

	public int Gspeed = 27;
	public int Jspeed = 34;
	public Rigidbody LRB;

	void Start () {
		
	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal") * Gspeed * Time.deltaTime;
		float moveZ = Input.GetAxis ("Vertical") * Gspeed * Time.deltaTime;
		float moveY = Input.GetAxis ("Jump") * Jspeed * Time.deltaTime;

		if (Input.GetButton ("Horizontal") || Input.GetButton ("Vertical")) {
			Debug.Log ("Bout to call input");
			Move(moveX, moveZ);
			Debug.Log ("Just called input");
		}

		if (Input.GetButton ("Jump")){
			Fly(moveY);
		}
	}

	void Move(float movex, float movez){
		Vector3 movement = new Vector3 (movex, 0.0f, movez);
		LRB.velocity = movement * Gspeed;
	}

	void Fly (float movey){
		Vector3 movement = new Vector3 (0.0f, movey, 0.0f);
		LRB.velocity = movement * Jspeed;
	}
}
