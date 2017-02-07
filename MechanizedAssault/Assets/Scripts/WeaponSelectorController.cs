using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WeaponSelectorController : MonoBehaviour {

	public int WeaponNumber = 0;
	public int WeaponSelector = 0;
	public float time = 0.0f;
	public int frameselector = 0;
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject FrameSpawn;
	public GameObject WeaponSpawn;
	//public FrameSelectorController FSC;
	//FrameModels
	public GameObject LightFrame;	
	public GameObject MediumFrame;
	public GameObject HeavyFrame;
	//Weapon GameObjects
	public GameObject SMG;
	public GameObject AssaultRifle;
	public GameObject LMG;
	public GameObject LongRifle;
	//Weapon Stats
	public Slider RangeSlider;
	public Slider RateOfFireSlider;
	public Slider DamageSlider;
	public Text AmmoCapacity;
	//buttons
	public Text nextbutton;
	public Text backbutton;
	public Text WeaponName;
	public Text WeaponType;

	void Start () {
		RangeSlider = GameObject.Find ("RangeSlider").GetComponent<Slider> ();
		RateOfFireSlider = GameObject.Find ("RateofFireSlider").GetComponent<Slider> ();
		DamageSlider = GameObject.Find ("DamageSlider").GetComponent<Slider> ();
		GameObject FrameSelectorObject = GameObject.Find ("FrameSelectController");
		FrameSelectorController FSC = FrameSelectorObject.GetComponent<FrameSelectorController> ();
		frameselector = FSC.FrameSelector;
		Debug.Log (FSC.FrameSelector + " This is the selected frame from the FrameSelectorController");
		Debug.Log(frameselector + " This is from the current Weapon Selector for frame selection");

		if (frameselector == 1) {
			GameObject LightFrameI = Instantiate (LightFrame);
			LightFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		} else {
			if (frameselector == 2) {
				GameObject MediumFrameI = Instantiate (MediumFrame);
				MediumFrameI.gameObject.transform.position = FrameSpawn.transform.position;
			} else {
				if (frameselector == 3) {
					GameObject HeavyFrameI = Instantiate (HeavyFrame);
					HeavyFrameI.gameObject.transform.position = FrameSpawn.transform.position;
				}
			}
		}

		GameObject SMGI = Instantiate(SMG);
		SMGI.gameObject.transform.position = WeaponSpawn.transform.position;
		WeaponName.text = ("SubMachine");
		WeaponType.text = ("Type: SMG");
		//Stats
		RangeSlider.value = 17;
		RateOfFireSlider.value = 41;
		DamageSlider.value = 20;
		AmmoCapacity.text = ("45");

		if (WeaponNumber <= 0) {
			backbutton.gameObject.SetActive (false);
		}
	}
	

	void Update () {

	
		time += Time.deltaTime;

		if (time <= 1.75f) {
			Camera1.gameObject.SetActive (true);
			Camera2.gameObject.SetActive (false);
		} else {
			Camera1.gameObject.SetActive (false);
			Camera2.gameObject.SetActive (true);
		}
	}

	public void NextButton (){
		WeaponNumber += 1;
		SelectWeapon ();
	}

	public void BackButton(){
		WeaponNumber -= 1;
		SelectWeapon ();
	}

	public void SelectWeapon(){
		if (WeaponNumber == 0) {
			GameObject SMGI = Instantiate (SMG);
			SMGI.gameObject.transform.position = WeaponSpawn.transform.position;
			WeaponName.text = ("SubMachine");
			WeaponType.text = ("Type: SMG");
			//Stats
			RangeSlider.value = 17;
			RateOfFireSlider.value = 41;
			DamageSlider.value = 20;
			AmmoCapacity.text = ("45");
			//DestroyCommands
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag("AssaultRifle"));
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LMG"));
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LongRifle"));
		} else {
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag("SMG"));
			if (WeaponNumber == 1) {
				GameObject AssaultRifleI = Instantiate (AssaultRifle);
				AssaultRifleI.gameObject.transform.position = WeaponSpawn.transform.position;
				WeaponName.text = ("AssaultRifle");
				WeaponType.text = ("Type: Assault Rifle");
				//Stats
				RangeSlider.value = 25;
				RateOfFireSlider.value = 34;
				DamageSlider.value = 27;
				AmmoCapacity.text = ("30");
				//DestroyCommands
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag("SMG"));
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LMG"));
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LongRifle"));
			} else {
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag("AssaultRifle"));
				if (WeaponNumber == 2) {
					GameObject LMGI = Instantiate (LMG);
					LMGI.gameObject.transform.position = WeaponSpawn.transform.position;
					WeaponName.text = ("LightMachine");
					WeaponType.text = ("Type: LMG");
					//Stats
					RangeSlider.value = 27;
					RateOfFireSlider.value = 30;
					DamageSlider.value = 19;
					AmmoCapacity.text = ("50");
					//DestroyCommands
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LongRifle"));
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag("AssaultRifle"));
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag("SMG"));
				} else {
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LMG"));
					if (WeaponNumber == 3) {
						GameObject LongRifleI = Instantiate (LongRifle);
						LongRifleI.gameObject.transform.position = WeaponSpawn.transform.position;
						WeaponName.text = ("SniperRifle");
						WeaponType.text = ("Type: Long Rifle");
						//Stats
						RangeSlider.value = 48;
						RateOfFireSlider.value = 10;
						DamageSlider.value = 45;
						AmmoCapacity.text = ("10");
						//DestroyCommands
						GameObject.DestroyObject (GameObject.FindGameObjectWithTag("AssaultRifle"));
						GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LMG"));
						GameObject.DestroyObject (GameObject.FindGameObjectWithTag("SMG"));
					} else {
						GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LongRifle"));
					}
				}
			}
		}

		if (WeaponNumber >= 3) {
			nextbutton.gameObject.SetActive (false);
		} else {
			nextbutton.gameObject.SetActive (true);
		}

		if (WeaponNumber <= 0) {
			backbutton.gameObject.SetActive (false);
		} else {
			backbutton.gameObject.SetActive (true);
		}
	}


	public void SelectButton(){
		switch (WeaponNumber) {
		case 0:
			WeaponSelector = 0;
			break;
		case 1:
			WeaponSelector = 1;
			break;
		case 2:
			WeaponSelector = 2;
			break;
		case 3:
			WeaponSelector = 3;
			break;
		}
		DontDestroyOnLoad (this);
		DestroyObject (GameObject.FindGameObjectWithTag ("FrameSelectController"));
		SceneManager.LoadScene ("TutorialLevel", LoadSceneMode.Single);
	}

}