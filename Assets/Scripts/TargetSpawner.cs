using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour {

	public GameObject targetObject;
	public ArrayList targets;
	// Use this for initialization
	void Start () {
		targets = new ArrayList();
		//targetObject.transform.position = RandomPosition ();
		//targets.Add (targetObject);
	}
	
	// Update is called once per frame
	void Update () {

		//Check if target is hit
		foreach (GameObject tar in targets) {
			if (tar.GetComponent<target_arcade> ().getIsHit ()) {
				Destroy (tar);
				targets.Remove (tar);

			}
		}
		if (targets.Count == 0) {
			targetObject = Instantiate(Resources.Load("Target"), RandomPosition(), Quaternion.identity) as GameObject;
			FixPosition(targetObject);
			targets.Add(targetObject);
			print ( "Target Position: " + targetObject.transform.position);
			}
	
	}

	Vector3 RandomPosition(){
		Vector3 randomscreenpos = Camera.main.ScreenToWorldPoint(new Vector3 ((float)Random.Range (0, Screen.width), (float)Random.Range(0, Screen.height), 5f));
//		GameObject tempObject = Instantiate(Resources.Load("Target"), Vector3.zero, Quaternion.identity) as GameObject;
//		print ("Radius: " + tempObject.renderer.bounds.size. / 2f);
//		Destroy (tempObject);
		//Vector3 randompos = new Vector3(randomscreenpos.x, randomscreenpos.y, 0f);

		return randomscreenpos;
		}
//
	void FixPosition(GameObject obj){
		float radius = obj.renderer.bounds.size.x / 2f;

		float left = Camera.main.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x;
		float bottom = Camera.main.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y;
		float right = Camera.main.ScreenToWorldPoint (new Vector3 ((float)Screen.width, (float)Screen.height, 0f)).x;
		float top = Camera.main.ScreenToWorldPoint (new Vector3 ((float)Screen.width, (float)Screen.height, 0f)).y;

		if (obj.transform.position.x < left + radius)
			obj.transform.position = new Vector3 (left + radius, obj.transform.position.y, obj.transform.position.z);
		if (obj.transform.position.y < bottom + radius)
			obj.transform.position = new Vector3 (obj.transform.position.x, bottom + radius, obj.transform.position.z);
		if (obj.transform.position.x > right - radius)
			obj.transform.position = new Vector3 (right - radius, obj.transform.position.y, obj.transform.position.z);
		if (obj.transform.position.y > top - radius)
			obj.transform.position = new Vector3 (obj.transform.position.x, top - radius, obj.transform.position.z);
	}

}
