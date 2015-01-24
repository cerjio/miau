﻿using UnityEngine;
using System.Collections;

public class MegamanControllerScript : MonoBehaviour {

	public float maxspeed = 10f;
	Animator anim;
	public Texture btnTexture;

	bool faceRight = true;
	public float Respawntime=1.0f;
	public float acel=1;
	public float speedFactor=5;
	public Transform respawnPosition;



	// Use this for initialization
	void Start () {
		//se llama al animator del personaje
		anim = GetComponent<Animator> ();
		respawnPosition.position = GameObject.FindGameObjectWithTag ("Spawn").transform.position;
	}
	


	void FixedUpdate() {
		float move = Input.GetAxis ("Horizontal");
		anim.SetFloat ("Speed",Mathf.Abs(move));
		rigidbody2D.velocity = new Vector2 (move*maxspeed, rigidbody2D.velocity.y);

		if (move > 0 &&! faceRight)
			Flip ();
		else if(move < 0 && faceRight)
			Flip ();

	}
	void Flip(){
		faceRight = !faceRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	// death from falling

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "bullet") {
			//if(this.rigidbody.velocity.magnitude >0.1){
			Destroy (this.gameObject);
			//StartCoroutine(DieAndRespawn()); 
			//}
				
		}
		
	}

	
	
	
	
}
