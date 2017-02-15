using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Text Flavortext1;
	public Text Flavortext2;
	public Text Flavortext3;

	void Start () {
		Flavortext1.text = (" ");
		Flavortext2.text = (" ");
		Flavortext3.text = (" ");
	}

	void Update () {
	}

	public void ImmediateSceneChange(){
		SceneManager.LoadScene ("SingleSelectorScene", LoadSceneMode.Single);
	}

	public void SingPlayerFlavorTextOn(){
		Flavortext1.text = ("Play either singleplayer or Co-op");
	}

	public void SingPlayerFlavorTextOff(){
		Flavortext1.text = (" ");
	}

	public void MultiPlayerFlavorTextOn(){
		Flavortext2.text = ("Player Vs. Player battles");
	}

	public void MultiPlayerFlavorTextOff(){
		Flavortext2.text = (" ");
	}

	public void TutorialFlavorTextOn(){
		Flavortext3.text = ("Learn how to play");
	}

	public void TutorialFlavorTextOff(){
		Flavortext3.text = (" ");
	}
}