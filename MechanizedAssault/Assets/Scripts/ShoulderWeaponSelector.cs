using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoulderWeaponSelector : MonoBehaviour {

	public float time = 0.0f;
	public int FramePick = 0;
	public int WeaponPick = 0;
	public GameObject Camera1;
	public GameObject Camera2;
	//Frames
	public GameObject LightFrame;
	public GameObject MediumFrame;
	public GameObject HeavyFrame;
	//Weapons
	public GameObject AssaultRifle;
	public GameObject SMG;
	public GameObject LMG;
	public GameObject LongRifle;
	public GameObject EnergyShot;
	public GameObject MultiMissle;
	public GameObject QuickShot;


	//Spawns
	public GameObject SpawnPoint;
	public GameObject WeaponSpawn;
	public GameObject ShoulderSpawn;

	void Start () {

		GameObject WeaponSelectorObject = GameObject.Find ("WeaponSelectionController");
		WeaponSelectorController WSC = WeaponSelectorObject.GetComponent<WeaponSelectorController> ();
		FramePick = WSC.frameselector;
		WeaponPick = WSC.WeaponSelector;

	
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

		switch (WeaponPick) {
		case 0:
			GameObject SMGI = Instantiate (SMG);
			SMGI.gameObject.transform.position = WeaponSpawn.transform.position;
			break;
		case 1:
			GameObject AssaultRifleI = Instantiate (AssaultRifle);
			AssaultRifleI.gameObject.transform.position = WeaponSpawn.transform.position;
			break;
		case 2:
			GameObject LMGI = Instantiate (LMG);
			LMGI.gameObject.transform.position = WeaponSpawn.transform.position;
			break;
		case 3:
			GameObject LongRifleI = Instantiate (LongRifle);
			LongRifleI.gameObject.transform.position = WeaponSpawn.transform.position;
			break;
		}
		GameObject.Destroy(GameObject.FindGameObjectWithTag("WeaponSelectController"));
	}
	

	void Update () {

		time += Time.deltaTime;

		if (time <= 2.0f) {
			Camera1.gameObject.SetActive (true);
			Camera2.gameObject.SetActive (false);
		} else {
			Camera1.gameObject.SetActive (false);
			Camera2.gameObject.SetActive (true);
		}
	}
}
