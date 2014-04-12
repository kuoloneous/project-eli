using UnityEngine;
using System.Collections;

public class buttonSound : MonoBehaviour {
	public AudioSource source;
	public GUIText button;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		source.Play ();



	}
	
}
