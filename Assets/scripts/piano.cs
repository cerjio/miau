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
		if (this.gameObject.tag == "bullet2") {
			//if(this.rigidbody.velocity.magnitude >0.1){
			Application.LoadLevel("Escena2_Atropellado");
			//StartCoroutine(DieAndRespawn()); 
			//}
			
		}
		
	}
}
