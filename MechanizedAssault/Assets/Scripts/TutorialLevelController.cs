using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLevelController : MonoBehaviour {

	public int FramePick;
	//Frames
	public GameObject LightFrame;
	public GameObject MediumFrame;
	public GameObject HeavyFrame;
	//spawns
	public GameObject SpawnPoint;
	public GameObject WeaponSpawn;

	void Start () {
		GameObject WeaponSelectorObject = GameObject.Find ("WeaponSelectionController");
		WeaponSelectorController WSC = WeaponSelectorObject.GetComponent<WeaponSelectorController> ();
		FramePick = WSC.frameselector;

		switch (FramePick){
		case 1:
			GameObject LightFrameI = Instantiate (LightFrame);
			LightFrameI.gameObject.transform.position = SpawnPoint.transform.position;
			break;
		case 2:
			GameObject MediumFrameI = Instantiate (MediumFrame);
			MediumFrameI.gameObject.transform.position = SpawnPoint.transform.position;
			break;
		case 3:
			GameObject HeavyFrameI = Instantiate (HeavyFrame);
			HeavyFrameI.gameObject.transform.position = SpawnPoint.transform.position;
			break;
		}

		GameObject.DestroyObject (GameObject.Find( "WeaponSelectionController"));
	}
	

	void Update () {
		
	}
}
