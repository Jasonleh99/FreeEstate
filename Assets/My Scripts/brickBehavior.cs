using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickBehavior : MonoBehaviour {

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
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name.Equals("bigBoyHammer")){
			gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		}
		AudioSource.PlayClipAtPoint(gameObject.GetComponentInParent<AudioSource>().clip, gameObject.transform.position);
	}
}
