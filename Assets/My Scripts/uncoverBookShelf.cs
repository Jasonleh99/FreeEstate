using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uncoverBookShelf : MonoBehaviour {
public bookSnap script1;
public bookSnap script2;
public bookSnap script3;
public float duration = 5f;
public float timeAlive = 0f;
public bool unFrozen = false;
private AudioSource audio;
private int count = 0;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(script1.activated && script2.activated && script3.activated && timeAlive < duration){
			if(!unFrozen){
				gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
			}
			if(count == 0){
				audio.Play();
				count++;
			}
			timeAlive += Time.deltaTime;
			gameObject.transform.Translate(gameObject.transform.forward * .3f * Time.deltaTime);
		}
		else if(timeAlive > duration){
			Destroy(audio);
		}
	}
}
