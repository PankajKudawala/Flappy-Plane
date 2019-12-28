using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Functions : MonoBehaviour {
	
	public GameObject green, red;
	public bool fstarted = false;
	public bool ingame = false;

	public void changePlane(){
		if (PlayerPrefs.HasKey ("plane")) {
			int x = PlayerPrefs.GetInt ("plane");
			if (x == 1) {
				PlayerPrefs.SetInt ("plane", 2);
				green.SetActive (true);
				red.SetActive (false);
			} else {
				PlayerPrefs.SetInt ("plane", 1);
				red.SetActive (true);
				green.SetActive (false);
			}
		} else {
			PlayerPrefs.SetInt ("plane", 1);
		}
	}

	public void StartGame(){
		SceneManager.LoadScene ("Gameplay");
		Debug.Log ("Started");
	}

	public void GoBack(){
		SceneManager.LoadScene ("Main Menu");
	}
}
