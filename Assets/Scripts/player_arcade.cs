using UnityEngine;
using System.Collections;

public class player_arcade : MonoBehaviour {

	public int score;
	int combo;
	int prevCombo;
	int timer = 30;
	public int time_left;
	public float start_time;
	public float time_past;
	public bool sessionEnded;
	public GUIText text_score;
	public GUIText text_timer;
	public GUIText text_high;
	public GUIText text_session;
	public GUIText textCombo;
	public GUIText textPraise;
	public Vector3 target_point; //where the ball hit
	public Vector3 mouse; //testing mouse points


	// Use this for initialization
	void Start () {
		start_time = Time.time; //get the current time
		score = 0; //start with no points
		time_left = timer;
		sessionEnded = false;
	}
	
	// Update is called once per frame
	void Update () {
		//time is up
		if (time_left <= 0) {
			//set high score if current score beat previous scores
			if(score > PlayerPrefs.GetInt("HighScore")){
				PlayerPrefs.SetInt("HighScore" , score);
			}
			sessionEnded = true;
		} else {
			time_past = Time.time - start_time; //get time elapsed
			time_left = Mathf.CeilToInt(timer - time_past); //make into an int 
		}

	}

	void OnGUI(){
		//change the live guitext objects to match the score and text variables
		text_score.text = "Score: " + score.ToString();
		text_timer.text = "Seconds Left: " + time_left.ToString();

		if (sessionEnded == true) {
			text_high.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
			text_session.text = "Session Score: " + score.ToString();
		}

		if (combo > 1) {
			textCombo.text = combo.ToString () + " Combo";
		} else {
			textCombo.text = "";
			textPraise.text = "";
		}
		
		if(combo == 2){
			textPraise.text = "Nice!";		
		}
		else if(combo == 3){
			textPraise.text = "Great!";
		}
		else if(combo == 4){
			textPraise.text = "Excellent!";
		}
		else if(combo == 5){
			textPraise.text = "Perfect!";
		}
		else if(combo > 5){
			textPraise.text = "Balls to the Wall!";
		}

		if (prevCombo > combo && prevCombo > 4) {
			textPraise.text = "COMBO BREAKER!";
		}

	}

	public void setCombo(int num){
		prevCombo = combo;
		combo = num;
	}

	public void incrementCombo(){
		prevCombo = combo;
		combo++;
	}

	public void increaseScore(int pointsToAdd){
		if (!sessionEnded) {
			score += pointsToAdd;
		}
	}
}