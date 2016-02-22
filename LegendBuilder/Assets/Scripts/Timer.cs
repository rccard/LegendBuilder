using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text grompTimer;
	public int grompTimeRemaining;

	float incrementTime = 1f;
	float incrementBy = 1;
	float counter = 0;
	double time = 0;


	// Use this for initialization
	void Start () {
		//Gromp spawns in 1:40 and respawns every 1:40 after
		//grompTimeRemaining = 10;

		//grompTimer = GameObject.Find ("GrompTimer").GetComponent<Text> ();
		grompTimer.text = "" + grompTimeRemaining;
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		while (time > incrementTime) {
			time -= incrementTime;
			counter += incrementBy;

			grompTimeRemaining--;
			grompTimer.text = "" + grompTimeRemaining;
		}


	
	}
}
