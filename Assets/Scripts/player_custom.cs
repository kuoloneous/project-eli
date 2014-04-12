using UnityEngine;
using System.Collections;

public class player_custom : MonoBehaviour {

	public int score;
	public float start_time;
	public float time_past;
	public GUIText text_score;
	public GUIText text_timer;
	public GUIText text_final;
	public GUIText text_elapsed;
	public bool sessionEnded;

	// Use this for initialization
	void Start () {
		start_time = Time.time; //get the current time
		score = 0; //start with no points
	}
	
	// Update is called once per frame
	void Update () {
		time_past = Mathf.CeilToInt(Time.time - start_time); //get time elapsed, make into int

		//if quit with camera
		//sessionEnded = true
	}

	void OnGUI(){
		//change the live guitext objects to match the score and text variables
		text_score.text = score.ToString();
		text_timer.text = "Seconds Elapsed: " + time_past.ToString();

		if (sessionEnded) {
			text_final.text = "Final Score: " + score.ToString();
			text_elapsed.text = "Time Spent: " + time_past.ToString();
		}
	}

	public void increaseScore(int pointsToAdd){
		if (!sessionEnded) {
			score += pointsToAdd;
		}
	}
}