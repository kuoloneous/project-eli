using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour {

	public GameObject targetObject;
	public ArrayList targets;
	// Use this for initialization
	void Start () {
		targets = new ArrayList();
		targetObject.transform.position = RandomPosition ();
		targets.Add (targetObject);
	}
	
	// Update is called once per frame
	void Update () {

		//Check if target is hit
		foreach (GameObject tar in targets) {
			tar.GetComponent()
			   }
		if (targets.Count == 0) {
			targetObject = Instantiate(targetObject, RandomPosition(), Quaternion.identity) as GameObject;
			targets.Add(targetObject);
			print ( "Target Position: " + targetObject.transform.position);
			}
	
	}

	Vector3 RandomPosition(){
		Vector2 randomscreenpos = Camera.main.ScreenToWorldPoint(new Vector3 (Random.value, Random.value, 0));
		Vector3 randompos = new Vector3(randomscreenpos.x, randomscreenpos.y, 0f);

		return randompos;
		}

}
