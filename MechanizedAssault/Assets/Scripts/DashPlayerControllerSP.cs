using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPlayerControllerSP : MonoBehaviour {

	public int Gspeed = 27;
	public int Jspeed = 34;
	public Rigidbody LRB;
	public bool OnGround=true;

	void Start () {
		
	}

	void Update () {

		OnGroundCheck ();

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
		OnGroundCheck ();
		if (OnGround == false) {
			Debug.Log ("You are now off of the ground");
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

	void OnGroundCheck(){

	}

	void OnTriggerStay (Collider other){

		if (other.tag == "Terrain") {
			OnGround = true;
		} else {
			OnGround = false;
		}
	}
}
