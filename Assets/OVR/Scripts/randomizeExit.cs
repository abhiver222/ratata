using UnityEngine;
using System.Collections;

public class randomizeExit : MonoBehaviour {
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject sphere3;
	private ArrayList listDone;
	//ADD NEW POSITIONS
	Vector3[] arrayPoints = {new Vector3 (-44.0807f, -0.5106478f, -53.09172f), 
		new Vector3 (49.5993f, 0.5106478f, -48.03418f), new Vector3 (-49.73071f, 0.5106478f, 38.74f), 
		new Vector3 (49.22929f, 0.5106478f, -53.37172f), new Vector3 (11.26f, 0.5106478f, -32.82f), new Vector3 (-44.67f, 0.5106478f, -54.93f), 
		new Vector3 (49.1793f, 0.5106478f, 21.51f), new Vector3 (-49.42f, 0.5106478f, -8.36f)};

	// Use this for initialization
	void Start () {
		listDone = new ArrayList ();
		System.Random rand = new System.Random ();
		int randInt = -1;
		do
		{
			randInt = rand.Next(0, 7);
			print(randInt);
			if(!listDone.Contains(randInt))
				listDone.Add(randInt);
		}while(listDone.Count <= 3);

		sphere1.transform.position = arrayPoints[(int)listDone[0]];
		sphere2.transform.position = arrayPoints[(int)listDone[1]];
		sphere3.transform.position = arrayPoints[(int)listDone[2]];	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
