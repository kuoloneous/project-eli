using UnityEngine;
using System.Collections;

public class destroy_delay : MonoBehaviour {

	public float delay;

	// Use this for initialization
	void Start () {
		delay = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, delay);
	}
}