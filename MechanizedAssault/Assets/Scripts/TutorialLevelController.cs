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
			GameObject LightFrameI = Instantiate (LightFrame);
			LightFrameI.gameObject.transform.position = SpawnPoint.transform.position;
			//LightFrame.transform.parent = transform;
			PickedFrame = LightFrameI;
			break;
		case 2:
			GameObject MediumFrameI = Instantiate (MediumFrame);
			MediumFrameI.gameObject.transform.position = SpawnPoint.transform.position;
			//MediumFrame.transform.parent = transform;
			PickedFrame = MediumFrameI;
			break;
		case 3:
			GameObject HeavyFrameI = Instantiate (HeavyFrame);
			HeavyFrameI.gameObject.transform.position = SpawnPoint.transform.position;
			//HeavyFrame.transform.parent = transform;
			PickedFrame = HeavyFrameI;
			//PickedFrame.transform.parent = transform;
			break;
		}
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("SingleSelectController"));
		WeaponSpawn = GameObject.FindGameObjectWithTag ("WeaponSpawn");
		ShoulderSpawn = GameObject.FindGameObjectWithTag ("ShoulderSpawn");
		PackSpawn = GameObject.FindGameObjectWithTag ("FlightPackSpawn");

		switch (WeaponPick) {
		case 0:
			GameObject SMGI = Instantiate (SMG);
			SMGI.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = SMGI;
			break;
		case 1:
			GameObject AssaultRifleI = Instantiate (AssaultRifle);
			AssaultRifleI.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = AssaultRifleI;
			break;
		case 2:
			GameObject LMGI = Instantiate (LMG);
			LMGI.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = LMGI;
			break;
		case 3:
			GameObject LongRifleI = Instantiate (LongRifle);
			LongRifleI.gameObject.transform.position = WeaponSpawn.transform.position;
			PickedMainWeapon = LongRifleI;
			break;
		}

		switch (ShoulderPick) {
		case 0:
			GameObject EnergyShotI = Instantiate (EnergyShot);
			EnergyShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
			PickedShoulder = EnergyShotI;
			break;
		case 1:
			GameObject MultiMissleI = Instantiate (MultiMissle);
			MultiMissleI.gameObject.transform.position = ShoulderSpawn.transform.position;
			PickedShoulder = MultiMissleI;
			break;
		case 2:
			GameObject QuickShotI = Instantiate (QuickShot);
			QuickShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
			PickedShoulder = QuickShotI;
			break;
		}

		switch (FlightPackPick) {
		case 1:
			GameObject StandardPackI = Instantiate (StandardPack);
			StandardPackI.gameObject.transform.position = PackSpawn.transform.position;
			PickedFlightPack = StandardPackI;
			SetParent ();
			break;
		case 2:
			GameObject PulsePackI = Instantiate (PulsePack);
			PulsePackI.gameObject.transform.position = PackSpawn.transform.position;
			PickedFlightPack = PulsePackI;
			SetParent ();
			break;
		}
	}
	

	void Update () {
	}

	public void SetParent (){
		Debug.Log ("Starting Parent Set");
		PickedMainWeapon.transform.parent = PickedFrame.transform;
		PickedShoulder.transform.parent = PickedFrame.transform;
		PickedFlightPack.transform.parent = PickedFrame.transform;
		Debug.Log ("Finishing Parent set");
	}
}
