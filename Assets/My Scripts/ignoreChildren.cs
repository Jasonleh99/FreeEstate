using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreChildren : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Collider[] list = gameObject.GetComponentsInChildren<Collider>(false);
		for(int i = 0; i < list.Length; i++){
			Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), list[i]);
		}
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
		
	}

}
