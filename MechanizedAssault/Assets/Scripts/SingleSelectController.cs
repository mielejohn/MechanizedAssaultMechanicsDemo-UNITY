using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SingleSelectController : MonoBehaviour {

	//Frames Items
	public int FrameSelector = 0;
	public GameObject LightFrame;	
	public int LightSelected = 1;
	public GameObject MediumFrame;
	public int MediumSelected = 2;
	public GameObject HeavyFrame;
	public int HeavySelected = 3;
	public Text FrameType;
	public GameObject FrameSpawn;
	private GameObject PlayerCamera;

	//Weapon Items
	public GameObject SMG;
	public GameObject AssaultRifle;
	public GameObject LMG;
	public GameObject LongRifle;
	public int WeaponNumber = 0;
	public int WeaponSelector = 0;
	private GameObject CameraWeaponOneAnimated;
	private GameObject CameraWeaponTwoStable;

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
	private Text FrameName;
	private Text LightButton;
	private Text MediumButton;
	private Text HeavyButton;

	//MISC
	public Text ScreenTitle;
	public float time = 0.0f;
	private GameObject MainCamera;


	void Start () {
		FrameType = GameObject.FindGameObjectWithTag ("FrameType").GetComponent<Text> ();
		//Weight Items
		LableOne = GameObject.FindGameObjectWithTag ("LableOne").GetComponent<Text> ();
		LableOne.text = ("Weight");
		SliderOne = GameObject.Find ("Slider1").GetComponent<Slider> ();
		//Armor Items
		LableTwo = GameObject.FindGameObjectWithTag ("LableTwo").GetComponent<Text> ();
		LableTwo.text = ("Armor");
		SliderTwo = GameObject.Find ("Slider2").GetComponent<Slider> ();
		//Speed Items
		LableThree = GameObject.FindGameObjectWithTag ("LableThree").GetComponent<Text> ();
		LableThree.text = ("Speed");
		SliderThree = GameObject.Find ("Slider3").GetComponent<Slider> ();
		//Flight Speed Items
		LableFour = GameObject.FindGameObjectWithTag ("LableFour").GetComponent<Text> ();
		LableFour.text = ("Flight Speed");
		SliderFour = GameObject.Find ("Slider4").GetComponent<Slider> ();

		CameraWeaponOneAnimated = GameObject.FindGameObjectWithTag ("AnimationCamera");
		CameraWeaponTwoStable = GameObject.FindGameObjectWithTag ("StableCamera");
		CameraWeaponOneAnimated.gameObject.SetActive (false);
		CameraWeaponTwoStable.gameObject.SetActive (false);
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
		Debug.Log ("Havent crashed on click");
		FrametoWeapon();
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
		Debug.Log ("Havent crashed on click");
		FrametoWeapon();
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
		GameObject HeavyFrameI = Instantiate (HeavyFrame);
		HeavyFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		PlayerCamera = GameObject.FindGameObjectWithTag ("PlayerCamera");
		PlayerCamera.SetActive (false);
		FrameSelector += 3;
		time = 0;
		Debug.Log  ("Havent crashed on click");
		FrametoWeapon();
	}

	public void HeavyFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("HeavyFrame"));
		FrameType.text = ("");

		SliderOne.value = 0;
		SliderTwo.value = 0;
		SliderThree.value = 0;
		SliderFour.value = 0;
	}

	public void FrametoWeapon(){
		Debug.Log ("Havent crashed on FrameToWeapon Start");
		time = 0;
		MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		MainCamera.gameObject.SetActive (false);
		Debug.Log ("Havent crashed right before while loop");
			if (time <= 2.00f) {
				CameraWeaponOneAnimated.gameObject.SetActive (true);
				CameraWeaponTwoStable.gameObject.SetActive (false);
			} else {
				CameraWeaponOneAnimated.gameObject.SetActive (false);
				CameraWeaponTwoStable.gameObject.SetActive (true);
		}
	}
}