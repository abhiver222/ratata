using UnityEngine;
using System.Collections;

public class MenuRotation : MonoBehaviour {
	
	public GameObject cam;
	public GameObject menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//menu.transform.eulerAngles = new Vector3 (-cam.transform.eulerAngles.x,cam.transform.eulerAngles.y+180,cam.transform.eulerAngles.z);
		//menu.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y, cam.transform.position.z -10);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("first");
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel("rules");
		}
	}
}
