using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoulderWeaponSelector : MonoBehaviour {

	public float time = 0.0f;
	public int FramePick = 0;
	public int WeaponPick = 0;
	public int ShoulderSelect = 0;
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
	//Weapon Stats
	public Slider RangeSlider;
	public Slider RateOfFireSlider;
	public Slider DamageSlider;
	public Text AmmoCapacity;
	//Spawns
	public GameObject SpawnPoint;
	public GameObject WeaponSpawn;
	public GameObject ShoulderSpawn;
	//buttons
	public Text nextbutton;
	public Text backbutton;
	public Text WeaponName;
	public Text WeaponType;

	void Start () {

		RangeSlider = GameObject.Find ("RangeSlider").GetComponent<Slider> ();
		RateOfFireSlider = GameObject.Find ("RateofFireSlider").GetComponent<Slider> ();
		DamageSlider = GameObject.Find ("DamageSlider").GetComponent<Slider> ();
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

		GameObject EnergyShotI = Instantiate (EnergyShot);
		EnergyShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
		WeaponName.text = ("Energy Shot");
		WeaponType.text = ("Type: Beam");
		//Stats
		RangeSlider.value = 47;
		RateOfFireSlider.value = 20;
		DamageSlider.value = 37;
		AmmoCapacity.text = ("∞");
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



	public void NextButton(){
		ShoulderSelect += 1;
		WeaponNumberPick ();
	}

	public void BackButton(){
		ShoulderSelect += 1;
		WeaponNumberPick ();
	}

	public void WeaponNumberPick(){
		if (ShoulderSelect == 0) {
			GameObject EnergyShotI = Instantiate (EnergyShot);
			EnergyShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
			WeaponName.text = ("Energy Shot");
			WeaponType.text = ("Type: Beam");
			//Stats
			RangeSlider.value = 47;
			RateOfFireSlider.value = 20;
			DamageSlider.value = 37;
			AmmoCapacity.text = ("∞");
			//DestroyCommands
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("MultiMissle"));
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("QuickShot"));

		} else {
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("EnergyShot"));
			if (ShoulderSelect == 1) {
				GameObject MultiMissleI = Instantiate (MultiMissle);
				MultiMissleI.gameObject.transform.position = ShoulderSpawn.transform.position;
				WeaponName.text = ("Multi-Missle");
				WeaponType.text = ("Type: Missle Launcher");
				//Stats
				RangeSlider.value = 39;
				RateOfFireSlider.value = 27;
				DamageSlider.value = 40;
				AmmoCapacity.text = ("35");
				//DestroyCommands
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("EnergyShot"));
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("QuickShot"));
			} else {
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("MultiMissle"));
				if (ShoulderSelect == 2) {
					GameObject QuickShotI = Instantiate (QuickShot);
					QuickShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
					WeaponName.text = ("Quick Shot");
					WeaponType.text = ("Type: Heavy Rifle");
					//Stats
					RangeSlider.value = 44;
					RateOfFireSlider.value = 25;
					DamageSlider.value = 37;
					AmmoCapacity.text = ("32");
					//DestroyCommands
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("MultiMissle"));
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("EnergyShot"));

				} 
			}
		}
	}
}