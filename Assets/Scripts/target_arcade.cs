using UnityEngine;
using System.Collections;

public class target_arcade : MonoBehaviour {

	public CircleCollider2D targetCollider1; //the smallest target
	public CircleCollider2D targetCollider2; //the target
	public CircleCollider2D targetCollider3; //the target
	public CircleCollider2D targetCollider4; //the largest target
	GameObject Player;
	player_arcade myPlayer;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		myPlayer = Player.GetComponent <player_arcade>(); //need to access the player
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		if(targetCollider1.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (100); //use the player to add to their score
		}
		else if(targetCollider2.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (75); //use the player to add to their score
		}
		else if(targetCollider3.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (50); //use the player to add to their score
		}
		else if(targetCollider4.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (25); //use the player to add to their score
		}

	}
}
