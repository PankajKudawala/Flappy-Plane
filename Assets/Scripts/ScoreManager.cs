using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public static ScoreManager instance;
	public int score;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		score = 0;
		PlayerPrefs.SetInt ("score", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncrementScore(){
		score++;
	}

	public void StopScore(){
		PlayerPrefs.SetInt ("score", score);
		if (PlayerPrefs.HasKey ("highscore")) {
			if (score > PlayerPrefs.GetInt ("highscore")) {
				PlayerPrefs.SetInt ("highscore", score);
			}
		} else {
			PlayerPrefs.SetInt ("highscore", score);
		}
	}
}
