using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class waterRise : MonoBehaviour {
public Transform waterTransform;
public float duration = 2f;
public float flowSpeed = 0.1f;
private float timeAlive = 0f;
private bool alive = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(alive){
			if(timeAlive > duration){
				alive = false;
				Destroy(gameObject.GetComponent<AudioSource>());
			}
			waterTransform.SetPositionAndRotation(new Vector3(waterTransform.position.x, waterTransform.position.y + flowSpeed * Time.deltaTime, waterTransform.position.z), waterTransform.rotation);
			timeAlive += Time.deltaTime;
		}
	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name.Equals("Sphere")) {
			alive = true;
			gameObject.GetComponent<AudioSource>().Play();
		}
	}
}
