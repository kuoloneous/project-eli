using UnityEngine;
using System.Collections;

public class hit_point : MonoBehaviour {

	public GameObject prefab;
	public Vector3 mousePos, worldPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			print (mousePosition);
			mousePos = new Vector3 ( mousePosition.x, mousePosition.y, 0f);
			GameObject obj = Instantiate(prefab, mousePos, Quaternion.identity) as GameObject;
		}
	}
}
