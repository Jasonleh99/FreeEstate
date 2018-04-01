using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpCam : MonoBehaviour {
public Transform cameraTransform;
public float moveSpeed = 10f;
public float mouseSensitivity = 0.08f;
private bool cursorLocked = true;
private Vector3 eulers;
	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible = false;
		eulers = cameraTransform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("AlternateCursor")){
			if(cursorLocked){
				Cursor.lockState = CursorLockMode.None;
			}
			else{
				Cursor.lockState = CursorLockMode.Locked;
			}
			cursorLocked = !cursorLocked;
			//Cursor.visible = true;
		}

		handleMouseMovement();
		handleCameraMovement();
	}

	void handleMouseMovement(){
		if(Input.GetAxis("Mouse X") != 0){
			eulers.y += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		}
		if(Input.GetAxis("Mouse Y") != 0){
			eulers.x -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		}
		cameraTransform.eulerAngles = eulers;
	}
	void handleCameraMovement(){
		Vector3 pos = cameraTransform.position;

		if(Input.GetAxis("Horizontal") != 0){
			cameraTransform.position += cameraTransform.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		}

		if(Input.GetAxis("Vertical") != 0){
			cameraTransform.position += cameraTransform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
		}

		if(Input.GetAxis("Mouse ScrollWheel") != 0){
			cameraTransform.position += cameraTransform.up * Input.GetAxis("Mouse ScrollWheel") * moveSpeed * Time.deltaTime;
		}
	}
}
