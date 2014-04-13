using UnityEngine;
using System.Collections;

public class target_arcade : MonoBehaviour {

	public CircleCollider2D targetCollider1; //the smallest target
	public CircleCollider2D targetCollider2; //the target
	public CircleCollider2D targetCollider3; //the target
	public CircleCollider2D targetCollider4; //the largest target
	public AudioSource hitSound;
	public GameObject explosion;
	bool isHit;

	GameObject Player;
	player_arcade myPlayer;

	// Use this for initialization
	void Start () {
		isHit = false;
		Player = GameObject.Find ("Player");
		myPlayer = Player.GetComponent <player_arcade>(); //need to access the player

		//textCombo = GameObject.Find("text_combo").GetComponent<GUIText> ();
		//textPraise = GameObject.Find ("text_praise").GetComponent<GUIText> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public bool getIsHit(){
		return isHit;
	}

	void OnMouseDown(){
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePosition.z = -5f;

		if(targetCollider1.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (100); //use the player to add to their score
			GameObject obj = Instantiate(explosion, mousePosition, Quaternion.identity) as GameObject;
			explode(Color.red, obj);
			myPlayer.incrementCombo();
		}
		else if(targetCollider2.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (75); //use the player to add to their score
			GameObject obj = Instantiate(explosion, mousePosition, Quaternion.identity) as GameObject;
			explode(Color.yellow, obj);
			myPlayer.setCombo(0);
		}
		else if(targetCollider3.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (50); //use the player to add to their score
			GameObject obj = Instantiate(explosion, mousePosition, Quaternion.identity) as GameObject;
			explode(Color.blue, obj);
			myPlayer.setCombo(0);
		}
		else if(targetCollider4.OverlapPoint(mousePosition))			
		{
			myPlayer.increaseScore (25); //use the player to add to their score
			GameObject obj = Instantiate(explosion, mousePosition, Quaternion.identity) as GameObject;
			explode(Color.white, obj);
			myPlayer.setCombo(0);
		}

	}

	void explode(Color ringColor, GameObject obj){
		hitSound.Play();
		obj.GetComponent<ParticleSystem>().startColor = ringColor;
		obj.GetComponent<ParticleSystem>().Play();
		isHit = true;
		
	}

}
