using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsControl : MonoBehaviour {
public switchBehavior yas;
private Light[] temp;
	// Use this for initialization
	void Start () {
		temp = GetComponentsInChildren<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		Light[] temp = GetComponentsInChildren<Light>();
		if(yas.lightsOn){
			for(int i = 0; i < temp.Length; i++){
				temp[i].enabled = true;
			}
		}
		else if(!yas.lightsOn){
			for(int i = 0; i < temp.Length; i++){
				temp[i].enabled = false;
			}
		}
	}
}
