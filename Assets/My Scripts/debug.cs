using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour {
public Rigidbody rigidbody;
public HingeJoint hinge;
	// Use this for initialization
	void Start () {
		hinge.useLimits = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			rigidbody.AddForce(gameObject.transform.forward * 100f);
		}
	}
}
