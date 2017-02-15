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
	private GameObject WeaponItems;
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
	private GameObject ShoulderItems;
	public int ShoulderSelector;
	private GameObject ShoulderSpawn;
	private GameObject CameraThreeAnimated;
	private GameObject CameraFourStable;
	public GameObject EnergyShot;
	public GameObject MultiMissle;
	public GameObject QuickShot;
	private Text Shouldernextbutton;
	private Text Shoulderbackbutton;

	//Flight Pack Items
	private GameObject FlightPackItems;
	public int FlightPackSelector;
	private GameObject FlightPackSpawn;
	public GameObject StandardFlightPack;
	public GameObject PulseFlightPack;
	private Text PulsePack;
	private Text StandardPack;
	private GameObject CameraFiveAnimated;
	private GameObject CameraSixStable;

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
	private Text TypeLable;
	public float time = 0.0f;
	private GameObject MainCamera;

	void Start () {
		FrameItems = GameObject.FindGameObjectWithTag ("FrameSelectionItems");
		ShoulderItems = GameObject.FindGameObjectWithTag ("ShoulderSelectionItems");
		ShoulderItems.gameObject.SetActive (false);
		WeaponSelection = GameObject.FindGameObjectWithTag ("WeaponSelectionItems");
		FlightPackItems = GameObject.FindGameObjectWithTag ("FlightPackItems");
		FlightPackSpawn = GameObject.FindGameObjectWithTag ("FlightPackSpawn");
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
		CameraFiveAnimated = GameObject.FindGameObjectWithTag ("CameraFive");
		CameraSixStable = GameObject.FindGameObjectWithTag ("CameraSix");
		CameraWeaponOneAnimated.gameObject.SetActive (false);
		CameraWeaponTwoStable.gameObject.SetActive (false);
		CameraThreeAnimated.gameObject.SetActive (false);
		CameraFourStable.gameObject.SetActive (false);
		CameraFiveAnimated.gameObject.SetActive (false);
		CameraSixStable.gameObject.SetActive (false);
		FlightPackSpawn = GameObject.FindGameObjectWithTag ("FlightPackSpawn");

		WeaponSelection.gameObject.SetActive (false);
		FlightPackItems.gameObject.SetActive (false);
	
		TypeLable = GameObject.FindGameObjectWithTag ("TypeLable").GetComponent<Text>();
	}

	void Update () {
		time += Time.deltaTime;	
	}

	//FRAME SELECTION
	//----------------------------------------------------------------------------------------------------------------------------------

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
		CameraWeaponOneAnimated.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		WeaponStartingLoad ();
		CameraWeaponOneAnimated.gameObject.SetActive (false);
		CameraWeaponTwoStable.gameObject.SetActive (true);
	}


	//STARTING THE WEAPON SELECTION
	//----------------------------------------------------------------------------------------------------------------------------------

	public void WeaponStartingLoad(){
		ScreenTitle.text = ("Pick a main weapon");
		TypeLable.text = ("Name:");
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
		backbutton.gameObject.SetActive (false);
	}
		
	public void WeaponNextButton (){
		WeaponNumber += 1;
		SelectMainWeapon ();
	}

	public void WeaponBackButton(){
		WeaponNumber -= 1;
		SelectMainWeapon ();
	}

	public void SelectMainWeapon(){
		if (WeaponNumber == 0) {
			backbutton.gameObject.SetActive (false);
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
				backbutton.gameObject.SetActive (true);
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
					nextbutton.gameObject.SetActive (true);
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
						nextbutton.gameObject.SetActive (false);
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
	}

	public void WeaponSelectButton(){
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
		ShoulderStartingLoad ();
		CameraWeaponTwoStable.gameObject.SetActive (false);
		CameraThreeAnimated.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		CameraThreeAnimated.gameObject.SetActive (false);
		CameraFourStable.gameObject.SetActive (true);
	}

	//SHOULDER WEAPON SELECTION
	//-------------------------------------------------------------------------------------------------------------------------------

	public void ShoulderStartingLoad (){
		ScreenTitle.text = ("Pick a shoulder weapon");
		TypeLable.text = ("Name:");
		ShoulderSpawn = GameObject.FindGameObjectWithTag ("ShoulderSpawn");
		GameObject EnergyShotI = Instantiate (EnergyShot);
		WeaponItems = GameObject.FindGameObjectWithTag ("WeaponSelectionItems");
		WeaponItems.gameObject.SetActive (false);
		ShoulderItems.gameObject.SetActive (true);
		Shouldernextbutton = GameObject.FindGameObjectWithTag ("NextButton").GetComponent<Text> ();
		Shoulderbackbutton = GameObject.FindGameObjectWithTag ("BackButton").GetComponent<Text> ();
		EnergyShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
		WeaponName.text = ("Energy Shot");
		WeaponType.text = ("Type: Beam");
		//Stats
		SliderTwo.value = 47;
		SliderThree.value = 20;
		SliderOne.value = 37;
		Ammunition.text = ("∞");
		Shoulderbackbutton.gameObject.SetActive (false);
	}

	public void ShoulderNextButton (){
		ShoulderSelector += 1;
		SelectShoulderWeapon ();
	}

	public void ShoulderBackButton(){
		ShoulderSelector -= 1;
		SelectShoulderWeapon ();
	}

	public void SelectShoulderWeapon(){
		if (ShoulderSelector == 0) {
			Shoulderbackbutton.gameObject.SetActive (false);
			GameObject EnergyShotI = Instantiate (EnergyShot);
			EnergyShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
			WeaponName.text = ("Energy Shot");
			WeaponType.text = ("Type: Beam");
			//Stats
			SliderOne.value = 37;
			SliderTwo.value = 47;
			SliderThree.value = 20;
			Ammunition.text = ("∞");
			//DestroyCommands
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("MultiMissle"));
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("QuickShot"));

		} else {
			GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("EnergyShot"));
			if (ShoulderSelector == 1) {
				Shoulderbackbutton.gameObject.SetActive (true);
				Shouldernextbutton.gameObject.SetActive (true);
				GameObject MultiMissleI = Instantiate (MultiMissle);
				MultiMissleI.gameObject.transform.position = ShoulderSpawn.transform.position;
				WeaponName.text = ("Multi-Missle");
				WeaponType.text = ("Type: Missle Launcher");
				//Stats
				SliderOne.value = 40;
				SliderTwo.value = 39;
				SliderThree.value = 27;
				Ammunition.text = ("35");
				//DestroyCommands
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("EnergyShot"));
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("QuickShot"));

			} else {
				GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("MultiMissle"));
				if (ShoulderSelector == 2) {
					Shouldernextbutton.gameObject.SetActive (false);
					GameObject QuickShotI = Instantiate (QuickShot);
					QuickShotI.gameObject.transform.position = ShoulderSpawn.transform.position;
					WeaponName.text = ("Quick Shot");
					WeaponType.text = ("Type: Heavy Rifle");
					//Stats
					SliderOne.value = 37;
					SliderTwo.value = 44;
					SliderThree.value = 25;
					Ammunition.text = ("32");
					//DestroyCommands
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("MultiMissle"));
					GameObject.DestroyObject (GameObject.FindGameObjectWithTag ("EnergyShot"));

				} 
			}
		}
	}

	public void ShoulderSelectButton(){
		switch (ShoulderSelector) {
		case 0:
			ShoulderSelector = 0;
			Debug.Log ("Right before the pack animation");
			StartCoroutine (FlightPackAnimation ());
			//DontDestroyOnLoad (this);
			//SceneManager.LoadScene ("TutorialLevel", LoadSceneMode.Single);
			break;
		case 1:
			ShoulderSelector = 1;
			Debug.Log ("Right before the pack animation");
			StartCoroutine (FlightPackAnimation ());
			//DontDestroyOnLoad (this);
			//SceneManager.LoadScene ("TutorialLevel", LoadSceneMode.Single);
			break;
		case 2:
			ShoulderSelector = 2;
			Debug.Log ("Right before the pack animation");
			StartCoroutine( FlightPackAnimation ());
			//DontDestroyOnLoad (this);
			//SceneManager.LoadScene ("TutorialLevel", LoadSceneMode.Single);
			break;
		}
	}

	IEnumerator FlightPackAnimation (){
		Debug.Log ("Starting the animation");
		FlightPackStartingLoad ();
		CameraFourStable.gameObject.SetActive (false);
		CameraFiveAnimated.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		CameraFiveAnimated.gameObject.SetActive (false);
		CameraSixStable.gameObject.SetActive (true);
	}

	//FLIGHT PACK SELECTION
	//---------------------------------------------------------------------------------------------------------------------------------

	public void FlightPackStartingLoad(){
		FlightPackItems.gameObject.SetActive (true);
		ScreenTitle.text = ("Pick a flight pack");
		ShoulderItems.gameObject.SetActive (false);
		TypeLable.gameObject.SetActive (false);
		WeaponName.gameObject.SetActive (false);
		LableOne.text = ("");
		SliderOne.gameObject.SetActive (false);
		LableTwo.text = ("");
		SliderTwo.gameObject.SetActive (false);
		LableThree.text = ("");
		SliderThree.gameObject.SetActive (false);
		LableFour.text = ("");
		Ammunition.text = ("");
	}

	public void StandardPackSelect(){
		GameObject StandardPackI = Instantiate (StandardFlightPack);
		StandardPackI.gameObject.transform.position = FlightPackSpawn.transform.position;
	}

	public void StandardPackDeSelect(){
		GameObject.Destroy (GameObject.FindGameObjectWithTag ("StandardPack"));
	}

	public void PulsePackSelect(){
		GameObject PulsePackI = Instantiate (PulseFlightPack);
		PulsePackI.gameObject.transform.position = FlightPackSpawn.transform.position;
	}

	public void PulsePackDeSelect(){
		GameObject.Destroy (GameObject.FindGameObjectWithTag ("PulsePack"));
	}
}