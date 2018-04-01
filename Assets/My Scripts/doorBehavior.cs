using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehavior : MonoBehaviour {
	public snapTo snap;
	// Use this for initialization
	public float timer = 0f;
	public int forwardBackward = -1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!snap.locked && timer < 2f) {
			gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
			gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 100f * forwardBackward, 0));
			timer += Time.deltaTime;
		}
	}
}
