using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SingleSelectController : MonoBehaviour {

	//Frames Items
	private GameObject FrameItems;
	public int FrameSelector;
	public GameObject LightFrame;	
	public int LightSelected = 1;
	public GameObject MediumFrame;
	public int MediumSelected = 2;
	public GameObject HeavyFrame;
	public int HeavySelected = 3;
	public Text FrameType;
	public GameObject FrameSpawn;
	private Text FrameName;
	private Text LightButton;
	private Text MediumButton;
	private Text HeavyButton;
	private GameObject PlayerCamera;

	//Weapon Items
	private GameObject WeaponSelection;
	public GameObject SMG;
	public GameObject AssaultRifle;
	public GameObject LMG;
	public GameObject LongRifle;
	public int WeaponNumber = 0;
	public int WeaponSelector = 0;
	private GameObject WeaponSpawn;
	private GameObject CameraWeaponOneAnimated;
	private GameObject CameraWeaponTwoStable;
	private Text nextbutton;
	private Text backbutton;
	private Text WeaponName;
	private Text WeaponType;

	//Shoulder Items
	private GameObject CameraThreeAnimated;
	private GameObject CameraFourStable;

	//Stat Items
	//Item1 is Weight
	private Text LableOne;
	private Slider SliderOne;
	//Slider2 is Armor
	private Text LableTwo;
	private Slider SliderTwo;
	//Slider3 is Speed
	private Text LableThree;
	private Slider SliderThree;
	//Slider4 is FlightSpeed
	private Text LableFour;
	private Slider SliderFour;
	private Text Ammunition;

	//MISC
	public Text ScreenTitle;
	public float time = 0.0f;
	private GameObject MainCamera;

	void Start () {
		FrameItems = GameObject.FindGameObjectWithTag ("FrameSelectionItems");
		FrameType = GameObject.FindGameObjectWithTag ("FrameType").GetComponent<Text> ();
		ScreenTitle = GameObject.FindGameObjectWithTag ("Title").GetComponent<Text> ();
		ScreenTitle.text = ("Select your frame");
		//Weight Items
		LableOne = GameObject.FindGameObjectWithTag ("LableOne").GetComponent<Text> ();
		LableOne.text = ("    Weight");
		SliderOne = GameObject.Find ("Slider1").GetComponent<Slider> ();
		//Armor Items
		LableTwo = GameObject.FindGameObjectWithTag ("LableTwo").GetComponent<Text> ();
		LableTwo.text = ("Armor");
		SliderTwo = GameObject.Find ("Slider2").GetComponent<Slider> ();
		//Speed Items
		LableThree = GameObject.FindGameObjectWithTag ("LableThree").GetComponent<Text> ();
		LableThree.text = ("        Speed");
		SliderThree = GameObject.Find ("Slider3").GetComponent<Slider> ();
		//Flight Speed Items
		LableFour = GameObject.FindGameObjectWithTag ("LableFour").GetComponent<Text> ();
		LableFour.text = ("Flight Speed");
		SliderFour = GameObject.Find ("Slider4").GetComponent<Slider> ();
		Ammunition = GameObject.FindGameObjectWithTag ("Ammo").GetComponent<Text> ();
		WeaponName = GameObject.FindGameObjectWithTag ("WeaponName").GetComponent<Text> ();
		WeaponType = GameObject.FindGameObjectWithTag ("WeaponType").GetComponent<Text> ();
		nextbutton = GameObject.FindGameObjectWithTag ("NextButton").GetComponent<Text> ();
		backbutton = GameObject.FindGameObjectWithTag ("BackButton").GetComponent<Text> ();

		CameraWeaponOneAnimated = GameObject.FindGameObjectWithTag ("AnimationCamera");
		CameraWeaponTwoStable = GameObject.FindGameObjectWithTag ("StableCamera");
		CameraThreeAnimated = GameObject.FindGameObjectWithTag ("Camerathree");
		CameraFourStable = GameObject.FindGameObjectWithTag ("CameraFour");
		CameraWeaponOneAnimated.gameObject.SetActive (false);
		CameraWeaponTwoStable.gameObject.SetActive (false);
		CameraThreeAnimated.gameObject.SetActive (false);
		CameraFourStable.gameObject.SetActive (false);
		WeaponSelection = GameObject.FindGameObjectWithTag ("WeaponSelectionItems");
		WeaponSelection.gameObject.SetActive (false);
	}

	void Update () {
		time += Time.deltaTime;	
	}

	public void LightFrameSelect(){
		GameObject LightFrameI = Instantiate (LightFrame);
		LightFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameType.text = ("M.I.S.C.U. Dash");

		SliderOne.value = 20;
		SliderTwo.value = 17;
		SliderThree.value = 40;
		SliderFour.value = 35;
	}

	public void LightFrameClick(){
		GameObject LightFrameI = Instantiate (LightFrame);
		LightFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameSelector += 1;
		MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		MainCamera.gameObject.SetActive (false);

		StartCoroutine(AnimationStart());
	}

	public void LightFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LightFrame"));
		FrameType.text = ("");

		SliderOne.value = 0;
		SliderTwo.value = 0;
		SliderThree.value = 0;
		SliderFour.value = 0;
	}

	public void MediumFrameSelect(){
		GameObject MediumFrameI = Instantiate (MediumFrame);
		MediumFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameType.text = ("M.I.S.C.U. Assault");

		SliderOne.value = 27;
		SliderTwo.value = 24;
		SliderThree.value = 30;
		SliderFour.value = 30;
	}

	public void MediumFrameClick(){
		GameObject MediumFrameI = Instantiate (MediumFrame);
		MediumFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameSelector += 2;
		MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		MainCamera.gameObject.SetActive (false);

		StartCoroutine(AnimationStart());

	}

	public void MediumFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("MediumFrame"));
		FrameType.text = ("");

		SliderOne.value = 0;
		SliderTwo.value = 0;
		SliderThree.value = 0;
		SliderFour.value = 0;
	}

	public void HeavyFrameSelect(){
		GameObject HeavyFrameI = Instantiate (HeavyFrame);
		HeavyFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameType.text = ("M.I.S.C.U. Support");
		Debug.Log ("MouseOver");

		SliderOne.value = 40;
		SliderTwo.value = 42;
		SliderThree.value = 20;
		SliderFour.value = 24;
	}

	public void HeavyFrameClick(){
		//Debug.Log  ("HeavyFrameClickStart");
		GameObject HeavyFrameI = Instantiate (HeavyFrame);
		HeavyFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameSelector += 3;
		MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		MainCamera.gameObject.SetActive (false);

		StartCoroutine(AnimationStart());
		//WeaponStartingLoad ();
	}

	public void HeavyFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("HeavyFrame"));
		FrameType.text = ("");

		SliderOne.value = 0;
		SliderTwo.value = 0;
		SliderThree.value = 0;
		SliderFour.value = 0;
	}

	IEnumerator AnimationStart(){
		Debug.Log ("AnimationStart");
		WeaponStartingLoad ();
		CameraWeaponOneAnimated.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		CameraWeaponOneAnimated.gameObject.SetActive (false);
		CameraWeaponTwoStable.gameObject.SetActive (true);
	}


	//STARTING THE WEAPON SELECTION
	//-----------------------------

	public void WeaponStartingLoad(){
		ScreenTitle.text = ("Pick a weapon");
		WeaponSelection.gameObject.SetActive (true);
		FrameItems.gameObject.SetActive (false);
		SliderFour.gameObject.SetActive (false);
		WeaponSpawn = GameObject.FindGameObjectWithTag ("WeaponSpawn");
		GameObject SMGI = Instantiate(SMG);
		SMGI.gameObject.transform.position = WeaponSpawn.transform.position;
		WeaponName.text = ("SMG");
		WeaponType.text = ("Type: SMG");
		LableOne.text = ("Damage");
		LableTwo.text = ("Range");
		LableThree.text = ("Rate of fire");
		LableFour.text = ("Ammunition");
		SliderTwo.value = 17;
		SliderThree.value = 41;
		SliderOne.value = 20;
		Ammunition.text = ("45");
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
			SliderOne.value = 20;
			SliderTwo.value = 17;
			SliderThree.value = 41;
			Ammunition.text = ("45");
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
				SliderOne.value = 27;
				SliderTwo.value = 25;
				SliderThree.value = 34;
				Ammunition.text = ("30");
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
					SliderOne.value = 19;
					SliderTwo.value = 27;
					SliderThree.value = 30;
					Ammunition.text = ("50");
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
						SliderOne.value = 45;
						SliderTwo.value = 48;
						SliderThree.value = 10;
						Ammunition.text = ("10");
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
			StartCoroutine (ShoulderAnimation ());
			break;
		case 1:
			WeaponSelector = 1;
			StartCoroutine (ShoulderAnimation ());
			break;
		case 2:
			WeaponSelector = 2;
			StartCoroutine (ShoulderAnimation ());
			break;
		case 3:
			WeaponSelector = 3;
			StartCoroutine (ShoulderAnimation ());
			break;
		}
	}

	IEnumerator ShoulderAnimation (){
		//ShoulderStartingLoad ();
		CameraWeaponTwoStable.gameObject.SetActive (false);
		CameraThreeAnimated.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		CameraThreeAnimated.gameObject.SetActive (false);
		CameraFourStable.gameObject.SetActive (true);
	}
	//SHOULDER WEAPON SELECTION

	public void ShoulderStartingLoad (){

	}


}