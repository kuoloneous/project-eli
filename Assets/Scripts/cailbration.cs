using UnityEngine;
using System.Collections;

public class cailbration : MonoBehaviour {

	public GUIStyle customRect;
	public Rect rectangle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		customRect.normal.background = new Texture2D(2, 2);
		GUI.backgroundColor = Color.red;
		GUI.Box(rectangle, new Texture2D(2, 2));
		GUI.Box (new Rect (0,0,Screen.width/4,20), "", customRect);
		GUI.Box (new Rect (0,0,20,Screen.height/4), "", customRect);

		GUI.Box (new Rect (Screen.width - Screen.width/4, 0, Screen.width/4, 20), "", customRect);
		GUI.Box (new Rect (Screen.width - 20, 0, 20, Screen.height/4), "", customRect);		


		GUI.Box (new Rect (0,Screen.height - 20,Screen.width/4,20), "", customRect);
		GUI.Box (new Rect (0,Screen.height - Screen.height/4 ,20,Screen.height/4), "", customRect);


		GUI.Box (new Rect (Screen.width - Screen.width/4, Screen.height - 20, Screen.width/4, 20), "", customRect);
		GUI.Box (new Rect (Screen.width - 20,Screen.height - Screen.height/4 ,20,Screen.height/4), "", customRect);
	}
}
