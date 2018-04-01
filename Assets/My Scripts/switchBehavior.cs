using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchBehavior : MonoBehaviour {
public bool lightsOn = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		gameObject.GetComponent<AudioSource>().Play();
		lightsOn = false;
	}
}
