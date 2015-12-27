using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class exitTimer : MonoBehaviour {

	private float time;
	private float minutes;
	public Text textShow;
	// Use this for initialization
	void Start () {
		time = 0;
		minutes = 1.5f;
	
	}
	
	// Update is called once per frame
	void Update () {		;
		int timeLeftInSeconds = (int)(minutes * 60 - time);

		TimeSpan t = TimeSpan.FromSeconds( timeLeftInSeconds );
		
		string timeLeftToShow = string.Format("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);
		textShow.text = "Time left: " + timeLeftToShow;


		time += Time.deltaTime;
		if (time >= minutes * 60) {
			Application.LoadLevel("end_lost_screen_time");
		}
	
	}
}
