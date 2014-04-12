using UnityEngine;
using System.Collections;

public class player_custom : MonoBehaviour {

	public int score;
	public float start_time;
	public float time_past;
	public GUIText text_score;
	public GUIText text_timer;

	public Vector3 target_point; //where the ball hit
	public Vector3 mouse; //testing mouse points

	// Use this for initialization
	void Start () {
		start_time = Time.deltaTime; //get the current time
		score = 0; //start with no points
	}
	
	// Update is called once per frame
	void Update () {
		time_past = Mathf.CeilToInt(Time.time - start_time); //get time elapsed, make into int
	}

	void OnGUI(){
		//change the live guitext objects to match the score and text variables
		text_score.text = score.ToString();
		text_timer.text = "Seconds Elapsed: " + time_past.ToString();
	}

	public void increaseScore(int pointsToAdd){
		score += pointsToAdd;
	}
}