using UnityEngine;
using System.Collections;

public class crazyColor : MonoBehaviour {
	public GUIText textObject;
	public float speed;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("animateColor", 0, speed);

	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void animateColor(){
		textObject.color = new Color(Random.value, Random.value, Random.value);
	}

	void OnMouseDown(){
		//textObject.text = "Clicked";
	}
}
