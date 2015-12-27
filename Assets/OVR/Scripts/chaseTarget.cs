using UnityEngine;
using System.Collections;

public class chaseTarget : MonoBehaviour {
	/*Next steps -
	Oculus guides
	Resize everything
	 */

	public Transform Player;
	public float chaseSpeed;
	public int MaxDistChase;
	public int MinDistChase;
	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;
	private bool agentStopped;
	private float lastChange;

	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		
		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;
		agentStopped = false;
		lastChange = 0.0f;
		GotoNextPoint();

	}

	void GotoNextPoint() {
		lastChange = 0.0f;
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;
		
		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		System.Random rnd = new System.Random ();
		int rand = rnd.Next(0, 10);
		destPoint = (destPoint + rand) % points.Length;
	}

	void Update () 
	{		
		float distanceBetween = (Vector3.Distance (transform.position, Player.transform.position));
		lastChange += Time.deltaTime;
		//Quit the game if caught
		if (distanceBetween < MinDistChase) {
			//CHANGE TO LOST SCREEN
			Application.LoadLevel("end_lost_screen");
		}

		//Chase
		else if (distanceBetween < MaxDistChase) {
			if(!agentStopped)
			{
				agent.Stop();
				agentStopped = true;
			}
			transform.LookAt (Player);
			transform.position += transform.forward * chaseSpeed * Time.deltaTime;
		}
		//Keep patrolling	
		else {
			if(agentStopped)
			{
				agentStopped = false;
				agent.Resume();
				GotoNextPoint();
			}

			else if (agent.remainingDistance < 2.5f || lastChange>=5.0f)
			{
				GotoNextPoint();
			}

		}

	}
}