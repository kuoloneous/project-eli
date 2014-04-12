using UnityEngine;
using System.Collections;

public class goto_custom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Application.LoadLevel ("custom");
	}
}
