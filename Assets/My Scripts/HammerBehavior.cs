using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerBehavior : MonoBehaviour {
public switchBehavior lightSwitch;
private Rigidbody body;
public float duration = 8f;
public float timeAlive = 0f;
private int count = 0;
public float hoverSpeedMod = .2f;
public bool enableHover = true;
public AudioSource hammerRise;
public AudioSource hammerHit;
	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody>();
	}
	// Update is called once per frame
	void Update () {
		if(!lightSwitch.lightsOn && timeAlive < duration){
			if(count == 0){
				body.constraints = RigidbodyConstraints.None;
				body.detectCollisions = false;
				gameObject.GetComponentInChildren<Light>().enabled = true;
				hammerRise.Play();
				count++;
			}
			gameObject.transform.Translate(gameObject.transform.up * .20f * Time.deltaTime);
			timeAlive += Time.deltaTime;
		}
		else if(timeAlive > duration){
			if(count == 1){
				body.detectCollisions = true;
				count++;
			}
			if(enableHover){
				hover();
			}
			timeAlive += Time.deltaTime;
		}
	}
	void hover(){
		gameObject.transform.Translate(gameObject.transform.up * Mathf.Sin(timeAlive * Mathf.PI) * Time.deltaTime * hoverSpeedMod);
	}
	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.gameObject.name);
		if(other.gameObject.name.Equals("Sphere")){
			enableHover = false;
			Destroy(hammerRise);
		}
	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		hammerHit.PlayOneShot(hammerHit.clip);
	}
}
