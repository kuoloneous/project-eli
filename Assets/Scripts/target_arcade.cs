using UnityEngine;
using System.Collections;

public class target_arcade : MonoBehaviour {

	public CircleCollider2D targetCollider1; //the smallest target
	public CircleCollider2D targetCollider2; //the target
	public CircleCollider2D targetCollider3; //the target
	public CircleCollider2D targetCollider4; //the largest target
	public AudioSource hitSound;
	public ParticleSystem explosion;
	 bool isHit;


	GameObject Player;
	player_arcade myPlayer;

	// Use this for initialization
	void Start () {
		isHit = false;
		Player = GameObject.Find ("Player");
		myPlayer = Player.GetComponent <player_arcade>(); //need to access the player
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public bool getIsHit(){
		return isHit;
		}
	void OnMouseDown(){
		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		if(targetCollider1.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (100); //use the player to add to their score
			explode(Color.red);
		}
		else if(targetCollider2.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (75); //use the player to add to their score
			explode(Color.yellow);
		}
		else if(targetCollider3.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (50); //use the player to add to their score
			explode(Color.blue);
		}
		else if(targetCollider4.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (25); //use the player to add to their score
			explode(Color.white);
		}

	}

	void explode(Color ringColor){
		hitSound.Play();
		explosion.startColor = ringColor;
		explosion.Play();
		isHit = true;

	}

}
