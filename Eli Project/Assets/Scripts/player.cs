using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public int score;
	public int timer;
	GUIText text_score;
	GUIText text_timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		text_score.text = score.ToString();
		text_timer.text = timer.ToString();
	}
}