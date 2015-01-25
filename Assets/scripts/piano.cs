using UnityEngine;
using System.Collections;

public class piano : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll) {
		
		//if(this.rigidbody.velocity.magnitude >0.1){
		Destroy (this.gameObject);
		
		
		
		
	}
}
