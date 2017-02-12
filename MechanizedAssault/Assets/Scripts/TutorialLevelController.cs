using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLevelController : MonoBehaviour {

	public int Framepick;
	public int WeaponPick;
	public int ShoulderPick;
	//Frames
	public GameObject LightFrame;
	public GameObject MediumFrame;
	public GameObject HeavyFrame;
	//Weapons
	public GameObject LongRifle;
	public GameObject SMG;
	public GameObject LMG;
	public GameObject AssaultRifle;
	//Shoulder
	public GameObject EnergyShot;
	public GameObject QuickShot;
	public GameObject MultiMissle;
	//spawns
	public GameObject SpawnPoint;
	private GameObject WeaponSpawn;
	private GameObject ShoulderSpawn;

	void Start () {
		GameObject ShoulderWeaponSelect = GameObject.Find ("ShoulderWeaponSelect");
		ShoulderWeaponSelector SWSC = ShoulderWeaponSelect.GetComponent<ShoulderWeaponSelector> ();
		Framepick = SWSC.FramePick;
		WeaponPick = SWSC.WeaponPick;
		ShoulderPick = SWSC.ShoulderSelect;

		switch (Framepick){
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
		GameObject.DestroyObject (GameObject.Find("ShoulderWeaponSelect"));
		WeaponSpawn = GameObject.FindGameObjectWithTag ("WeaponSpawn");
		ShoulderSpawn = GameObject.FindGameObjectWithTag ("ShoulderSpawn");

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

		switch (ShoulderPick) {
		case 0:
			GameObject EnergyShotI = Instantiate (EnergyShot);
			EnergyShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
			break;
		case 1:
			GameObject MultiMissleI = Instantiate (MultiMissle);
			MultiMissleI.gameObject.transform.position = ShoulderSpawn.transform.position;
			break;
		case 2:
			GameObject QuickShotI = Instantiate (QuickShot);
			QuickShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
			break;
		}
	}
	

	void Update () {
		
	}
}
