using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapTo : MonoBehaviour {
public string snapRef;
public GameObject key;
public bool locked = true;
	// Use this for initialization
	void Start () {
		renderChildren(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name.Equals(snapRef)){
			Destroy(key);
			renderChildren(true);
			locked = false;
			gameObject.GetComponent<AudioSource>().Play();
		}
	}

	void renderChildren(bool yas){
		Renderer[] list = gameObject.GetComponentsInChildren<Renderer>();
		for(int i = 0; i < list.Length; i++){
			list[i].enabled = yas;
		}
	}
}
