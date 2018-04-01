    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class bookSnap : MonoBehaviour {
public bool activated = false;
public float timeAlive = 0f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	    void Update () {
	    }

        /// <summary>
        /// OnCollisionStay is called once per frame for every collider/rigidbody
        /// that is touching rigidbody/collider.
        /// </summary>
        /// <param name="other">The Collision data associated with this collision.</param>
        void OnCollisionStay(Collision other)
        {
            if(other.gameObject.name.Equals("Book")){
                timeAlive += Time.deltaTime;
            }
            if(!activated && timeAlive >= 0.05f){
                Rigidbody temp = other.gameObject.GetComponent<Rigidbody>();
                temp.constraints = RigidbodyConstraints.FreezeAll;
                activated = true;
                other.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
            Debug.Log("In collision with: " + other.gameObject.name + " | For: " + timeAlive + "s");
        }

        /// <summary>
        /// OnCollisionExit is called when this collider/rigidbody has
        /// stopped touching another rigidbody/collider.
        /// </summary>
        /// <param name="other">The Collision data associated with this collision.</param>
        void OnCollisionExit(Collision other)
        {
            Debug.Log("Lost collision with: " + other.gameObject.name);
            timeAlive = 0;
        }
    }
