using UnityEngine;
using System.Collections;

public class motionControl : MonoBehaviour {

	public GameObject cam;
	private bool sprint;
	// Use this for initialization
	void Start () {
		sprint = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			cam.transform.eulerAngles = new Vector3(cam.transform.eulerAngles.x,cam.transform.eulerAngles.y - 20,cam.transform.eulerAngles.z);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			cam.transform.eulerAngles = new Vector3(cam.transform.eulerAngles.x,cam.transform.eulerAngles.y + 20,cam.transform.eulerAngles.z);
		}
		if (Input.GetKeyDown (KeyCode.Tab))
			sprint = !sprint;
		if (Input.GetKey (KeyCode.W)) {
			if(!sprint)
				cam.transform.position += (cam.transform.forward * (Time.deltaTime * 5));
			else {
				cam.transform.position += (cam.transform.forward * (Time.deltaTime * 9));
			}
		}
		if (Input.GetKey (KeyCode.S)) {
			cam.transform.position -= (cam.transform.forward * (Time.deltaTime));
		}
	}
}
