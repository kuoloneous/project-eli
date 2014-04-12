using UnityEngine;
using System.Collections;

public class target_custom : MonoBehaviour {

	CircleCollider2D targetCollider; //the target
	GameObject Player;
	player_custom myPlayer;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		myPlayer = Player.GetComponent <player_custom>(); //need to access the player
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		myPlayer.increaseScore (10); //use the player to add to their score
	}
}
