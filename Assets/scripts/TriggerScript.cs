using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "gato5") {

			GameObject honeycomb = GameObject.FindGameObjectWithTag ("honeycomb");
			honeycomb.rigidbody2D.isKinematic = false;
		}


	}
}
