using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hill : MonoBehaviour {

	public float speed =-4;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		MoveHill ();
	}

	// Update is called once per frame
	void Update () {

	}

	void MoveHill(){
		rb.velocity = new Vector2 (speed, 0);
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "HillRemover") {
			Destroy (gameObject);
		}
		if (coll.gameObject.tag == "Plane") {
			//Debug.Log ("Over");
		}
	}
}
