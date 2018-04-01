using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreThisWall : MonoBehaviour {
public Collider[] wall;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < wall.Length; i++){
			Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), wall[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
