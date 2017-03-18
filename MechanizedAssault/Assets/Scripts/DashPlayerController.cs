using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DashPlayerController : NetworkBehaviour {
	//private GameObject LightFrame;
	public Rigidbody LRB;
	[SyncVar]
	public float speed = 30.0f;


	void Start () {
		//LightFrame = GameObject.FindGameObjectWithTag ("LightFrame");
	}

	void Update () {
		Debug.Log ("Void Update is running");
		if (isLocalPlayer && hasAuthority) {
			Debug.Log ("Just found local player && Authority");
			if (Input.GetButton ("Horizontal") || Input.GetButton ("Vertical")) {
				Debug.Log ("Bout to call input");
				GetInput ();
				Debug.Log ("Just called input");
			}
		}
	}

	void GetInput(){
		Debug.Log ("GetInput was just called");
		float moveX = Input.GetAxis ("Horizontal") * speed + Time.deltaTime;
		float moveZ = Input.GetAxis ("Vertical") * speed + Time.deltaTime;

		if (isServer) {
			Debug.Log ("Calling RPC");
			RpcMove (moveX, moveZ);
		} else {
			Debug.Log ("Calling Command");
			CmdMove (moveX, moveZ);
		}
			
	}


	[ClientRpc]
	void RpcMove(float movex, float movez){
		Debug.Log("Starting RPC movement");

		Vector3 movement = new Vector3 (movex, 0.0f, movez);
		LRB.velocity = movement * speed;
	}

	[Command]
	void CmdMove(float movex, float movez){
		Debug.Log ("Starting CMD movement");
		RpcMove (movex, movez);
		//Vector3 movement = new Vector3 (movex, 0.0f, movez);
		//LRB.velocity = movement * speed;
	}
}
