using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLevelController : MonoBehaviour {

	public int Framepick;
	public int WeaponPick;
	public int ShoulderPick;
	public int FlightPackPick;
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
	//FlightPack
	public GameObject StandardPack;
	public GameObject PulsePack;
	//Picked Items
	public GameObject PickedFrame;
	public GameObject PickedMainWeapon;
	public GameObject PickedShoulder;
	public GameObject PickedFlightPack;
	//spawns
	public GameObject SpawnPoint;
	private GameObject WeaponSpawn;
	private GameObject ShoulderSpawn;
	private GameObject PackSpawn;

	void Start () {
		GameObject SingleSelectController = GameObject.FindGameObjectWithTag ("SingleSelectController");
		SingleSelectController SSC = SingleSelectController.GetComponent<SingleSelectController> ();
		Framepick = SSC.FrameSelector;
		WeaponPick = SSC.WeaponSelector;
		ShoulderPick = SSC.ShoulderSelector;
		FlightPackPick = SSC.FlightPackSelector;

		switch (Framepick){
		case 1:
			Instantiate (LightFrame);
			LightFrame.gameObject.transform.position = SpawnPoint.transform.position;
			PickedFrame = LightFrame;
			break;
		case 2:
			Instantiate (MediumFrame);
			MediumFrame.gameObject.transform.position = SpawnPoint.transform.position;
			PickedFrame = MediumFrame;
			break;
		case 3:
			Instantiate (HeavyFrame);
			HeavyFrame.gameObject.transform.position = SpawnPoint.transform.position;
			PickedFrame = HeavyFrame;
			break;
		}
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("SingleSelectController"));
		WeaponSpawn = GameObject.FindGameObjectWithTag ("WeaponSpawn");
		ShoulderSpawn = GameObject.FindGameObjectWithTag ("ShoulderSpawn");
		PackSpawn = GameObject.FindGameObjectWithTag ("FlightPackSpawn");

		switch (WeaponPick) {
		case 0:
			Instantiate (SMG);
			SMG.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = SMG;
			break;
		case 1:
			Instantiate (AssaultRifle);
			AssaultRifle.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = AssaultRifle;
			break;
		case 2:
			Instantiate (LMG);
			LMG.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = LMG;
			break;
		case 3:
			Instantiate (LongRifle);
			LongRifle.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = LongRifle;
			break;
		}

		switch (ShoulderPick) {
		case 0:
			Instantiate (EnergyShot);
			EnergyShot.gameObject.transform.position = ShoulderSpawn.transform.position;
			PickedShoulder = EnergyShot;
			break;
		case 1:
			Instantiate (MultiMissle);
			MultiMissle.gameObject.transform.position = ShoulderSpawn.transform.position;
			PickedShoulder = MultiMissle;
			break;
		case 2:
			Instantiate (QuickShot);
			QuickShot.gameObject.transform.position = ShoulderSpawn.transform.position;
			PickedShoulder = QuickShot;
			break;
		}

		switch (FlightPackPick) {
		case 1:
			Instantiate (StandardPack);
			StandardPack.gameObject.transform.position = PackSpawn.transform.position;
			PickedFlightPack = StandardPack;
			SetParent (PickedFrame);
			break;
		case 2:
			Instantiate (PulsePack);
			PulsePack.gameObject.transform.position = PackSpawn.transform.position;
			PickedFlightPack = PulsePack;
			SetParent (PickedFrame);
			break;
		}
	}
	

	void Update () {
		
	}

	public void SetParent (GameObject PickedFrame){
		PickedMainWeapon.transform.parent = PickedFrame.transform;
		PickedShoulder.transform.parent = PickedFrame.transform;
		PickedFlightPack.transform.parent = PickedFrame.transform;
	}
}
