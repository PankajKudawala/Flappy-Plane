using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillSpawner : MonoBehaviour {


	public float SpawnTime;
	public GameObject hill;
	public PlaneController pcontrol;

	// Use this for initialization
	void Start () {
			StartSpawningHills ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void StopSpawningHills(){
		CancelInvoke ("SpawnHills");
	}

	public void StartSpawningHills(){
		InvokeRepeating ("SpawnHills", 0.2f, SpawnTime);
	}

	void SpawnHills(){
		Instantiate(hill, new Vector3 (transform.position.x, Random.Range(2,7),0),Quaternion.identity);
	}
}
