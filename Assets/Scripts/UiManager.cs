using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class UiManager : MonoBehaviour {
	public static UiManager instance;
	public Text scoreText;
	public Text bestText;
	public GameObject gameOverPanel;


	// Use this for initialization

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	void Start () {
		Debug.Log (ScoreManager.instance.score);
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: "+ ScoreManager.instance.score.ToString();
		bestText.text = "Best: " + PlayerPrefs.GetInt ("highscore").ToString();
	}
	public void GameOver(){
		
	}

	public void Replay(){
		
	}

	public void Menu(){
		
	}
}
