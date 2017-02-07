using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FrameSelectorController : MonoBehaviour {

	public int FrameSelector = 0;
	//Light Frame MISCU
	public GameObject LightFrame;	
	public int LightSelected = 1;
	//Medium Frame MISCU
	public GameObject MediumFrame;
	public int MediumSelected = 2;
	//Heavy Frame MISCU
	public GameObject HeavyFrame;
	public int HeavySelected = 3;

	public Text FrameType;
	//Frmae Slider Stats
	public Slider WeightSlider;
	public Slider ArmorSlider;
	public Slider SpeedSlider;
	public Slider FlightSpeedSlider;
	public GameObject FrameSpawn;


	void Start () {
		FrameType = GameObject.Find ("FrameTypeName").GetComponent<Text> ();
		WeightSlider = GameObject.Find ("Weight Slider").GetComponent<Slider> ();
		ArmorSlider = GameObject.Find ("Armor Slider").GetComponent<Slider> ();
		SpeedSlider = GameObject.Find ("Speed Slider").GetComponent<Slider> ();
		FlightSpeedSlider = GameObject.Find ("Flight Speed Slider").GetComponent<Slider> ();
	}
	

	void Update () { 

	}

	public void LightFrameSelect(){
		GameObject LightFrameI = Instantiate (LightFrame);
		LightFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		FrameType.text = ("M.I.S.C.U. Dash");

		WeightSlider.value = 20;
		ArmorSlider.value = 17;
		SpeedSlider.value = 40;
		FlightSpeedSlider.value = 35;
	}

	public void LightFrameClick(){
		PlayerPrefs.SetInt ("FrameSelector", FrameSelector = 1);
		Debug.Log ("You Picked frame " + FrameSelector);
		DontDestroyOnLoad (this);
		SceneManager.LoadScene ("WeaponSelection Scene", LoadSceneMode.Single);
	}

	public void LightFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("LightFrame"));
		FrameType.text = ("");

		WeightSlider.value = 0;
		ArmorSlider.value = 0;
		SpeedSlider.value = 0;
		FlightSpeedSlider.value = 0;
	}

	public void MediumFrameSelect(){
		GameObject MediumFrameI = Instantiate (MediumFrame);
		MediumFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		FrameType.text = ("M.I.S.C.U. Assault");

		WeightSlider.value = 27;
		ArmorSlider.value = 24;
		SpeedSlider.value = 30;
		FlightSpeedSlider.value = 30;
	}

	public void MediumFrameClick(){
		PlayerPrefs.SetInt ("FrameSelector", FrameSelector = 2);
		Debug.Log ("You Picked frame " + FrameSelector);
		DontDestroyOnLoad (this);
		SceneManager.LoadScene ("WeaponSelection Scene", LoadSceneMode.Single);
	}

	public void MediumFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("MediumFrame"));
		FrameType.text = ("");

		WeightSlider.value = 0;
		ArmorSlider.value = 0;
		SpeedSlider.value = 0;
		FlightSpeedSlider.value = 0;
	}

	public void HeavyFrameSelect(){
		GameObject HeavyFrameI = Instantiate (HeavyFrame);
		HeavyFrameI.gameObject.transform.position = FrameSpawn.transform.position;
		FrameType.text = ("M.I.S.C.U. Support");

		WeightSlider.value = 40;
		ArmorSlider.value = 42;
		SpeedSlider.value = 20;
		FlightSpeedSlider.value = 24;
	}

	public void HeavyFrameClick(){
		PlayerPrefs.SetInt ("FrameSelector", FrameSelector = 3);
		Debug.Log ("You Picked frame " + FrameSelector);
		DontDestroyOnLoad (this);
		SceneManager.LoadScene ("WeaponSelection Scene", LoadSceneMode.Single);

	}

	public void HeavyFrameDeSelect(){
		GameObject.DestroyObject (GameObject.FindGameObjectWithTag("HeavyFrame"));
		FrameType.text = ("");

		WeightSlider.value = 0;
		ArmorSlider.value = 0;
		SpeedSlider.value = 0;
		FlightSpeedSlider.value = 0;
	}

}