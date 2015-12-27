using UnityEngine;
using System.Collections;

public class hole_exit : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Application.LoadLevel("end_screen");
	}

	void OnCollisionEnter(Collision col){
		Application.LoadLevel("end_screen");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
