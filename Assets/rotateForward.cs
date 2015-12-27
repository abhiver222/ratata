using UnityEngine;
using System.Collections;

public class rotateForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.LookAt (new Vector3(-1, -1, 0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
