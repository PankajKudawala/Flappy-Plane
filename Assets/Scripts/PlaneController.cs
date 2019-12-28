using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneController : MonoBehaviour {

    Rigidbody2D plane;
	public float  upforce =200;
	public bool started;
	bool gameOver;
	public HillSpawner hillspawner;
	public Functions f;
	public ScoreManager s;
	public GameObject green, red;

	void Start () {
		
		plane = GetComponent<Rigidbody2D> ();
		started = true;
		gameOver = false;
		int x = PlayerPrefs.GetInt ("plane");
		if (x == 2) {
			green.SetActive (true);
			red.SetActive (false);
		} else {
			red.SetActive (true);
			green.SetActive (false);
		}
	}

	void Update () {
		transform.Rotate (Vector3.back);
		if (!started) {
			if (Input.GetMouseButtonDown (0)) {
				started = true;
				plane.isKinematic = false;
				hillspawner.StartSpawningHills ();
			} 
		}
		else {
			if (Input.GetMouseButtonDown (0)) {
				plane.velocity = Vector2.zero;
				plane.AddForce (new Vector2 (0, upforce));
				transform.rotation = new Quaternion (0, 0, 90,90);
		    }
        }
}

	void OnCollisionEnter2D(Collision2D coll){
		s.StopScore ();
		SceneManager.LoadScene ("Gameplay");
		Debug.Log ("GAME OVER");
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Hill" ) {
			gameOver = true;
			s.IncrementScore ();
		}
	}
}
