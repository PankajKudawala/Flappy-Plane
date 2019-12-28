using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	public GameObject green, red;

	void Start () {
		if (!PlayerPrefs.HasKey ("first")) {
			PlayerPrefs.SetInt ("plane", 1);
			PlayerPrefs.SetInt ("first", 1);
		}
		if (PlayerPrefs.HasKey ("plane")) {
			int x = PlayerPrefs.GetInt ("plane");
			if (x == 2) {
				green.SetActive (true);
				red.SetActive (false);
			} else {
				red.SetActive (true);
				green.SetActive (false);
			}
		} 
		else {
			PlayerPrefs.SetInt ("plane", 1);
		}
	}

	void Update () {
		
	}
}
