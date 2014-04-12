﻿using UnityEngine;
using System.Collections;

public class player_arcade : MonoBehaviour {

	public int score;
	public int timer;
	public int time_left;
	public float start_time;
	public float time_past;
	public GUIText text_score;
	public GUIText text_timer;

	public Vector3 target_point; //where the ball hit
	public Vector3 mouse; //testing mouse points
	public GameObject point;

	// Use this for initialization
	void Start () {
		start_time = Time.deltaTime; //get the current time
		score = 0; //start with no points
		timer = 60; //60 seconds
	}
	
	// Update is called once per frame
	void Update () {
		time_past = Time.time - start_time; //get time elapsed
		time_left = Mathf.CeilToInt(timer - time_past); //make into an int 

		//time is up
		if (time_left <= 0) {
			//do something
		}
	}

	void OnGUI(){
		//change the live guitext objects to match the score and text variables
		text_score.text = score.ToString();
		text_timer.text = "Seconds Left: " + time_left.ToString();
	}

	void OnMouseDown(){
		Instantiate (point, Input.mousePosition, Quaternion.identity);
	}

	public void increaseScore(int pointsToAdd){
		score += pointsToAdd;
	}
}