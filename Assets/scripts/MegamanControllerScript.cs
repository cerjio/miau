using UnityEngine;
using System.Collections;

public class MegamanControllerScript : MonoBehaviour {

	public float maxspeed = 10f;
	Animator anim;
	public Texture btnTexture;

	public SpriteRenderer fondo2, fondo3, fondo4;

	bool faceRight = true;
	public float Respawntime=1.0f;
	public float acel=1;
	public float speedFactor=5;
	public Transform respawnPosition;


	// Controles
	public GameObject player;
	public float speed;


	// Use this for initialization
	void Start () {
		//se llama al animator del personaje
		anim = GetComponent<Animator> ();

		//Controles
		player = GameObject.FindGameObjectWithTag ("Player");
		speed = 5f;

	}
	
	void FixedUpdate() {
		{
			if (this.gameObject.transform.position.x >= 13)
				Application.LoadLevel ("Escena7_Panal");
			if (this.gameObject.transform.position.x <= -14)
				this.gameObject.transform.position = new Vector3 (-14, -1.4f);
		}

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


	void OnGUI () {
		
		if (!btnTexture) {
			
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		
		
		
		while (GUI.RepeatButton(new Rect(5,Screen.height-(btnTexture.height/4),btnTexture.width/4,btnTexture.height/4), btnTexture) ){
			player.transform.Translate(new Vector3(-(0.05f),0,0));

			fondo2.transform.Translate(new Vector3((0.01f),0,0));
			fondo3.transform.Translate(new Vector3((0.02f),0,0));
			fondo4.transform.Translate(new Vector3((0.04f),0,0));

			Debug.Log("izq");
			if(faceRight)
			{
				Flip();
				faceRight=false;
			}
			
		}
		
		// Make the second button.
		while (GUI.RepeatButton(new Rect((btnTexture.width/4)+5,Screen.height-(btnTexture.height/4),btnTexture.width/4,btnTexture.height/4),btnTexture ) ){
			player.transform.Translate(new Vector3((0.05f),0,0));

			fondo2.transform.Translate(new Vector3(-(0.01f),0,0));
			fondo3.transform.Translate(new Vector3(-(0.02f),0,0));
			fondo4.transform.Translate(new Vector3(-(0.04f),0,0));

			Debug.Log("der");
			if(!faceRight)
			{
				Flip();
				faceRight=true;
			}
		}

	}
	
	
	
	
}


/*
 * public float velocidadDespzamiento;
	public float velocidadGiro;

	public Transform fondo;

	// Use this for initialization
	void Start () {
		try{
			fondo = GameObject.FindGameObjectWithTag("fondo1").transform; 
		}catch{

		}
	}


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "treeHole")
						Destroy (coll.gameObject);	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow))	
		{
			this.transform.Translate(Vector3.left * velocidadDespzamiento);

			try{
			fondo.Translate(Vector3.left * velocidadDespzamiento);
			}catch{}
			//
		}

		if (Input.GetKey(KeyCode.RightArrow))	
		{
			this.transform.Translate(Vector3.right * velocidadDespzamiento);	
		}

		if (Input.GetKey(KeyCode.UpArrow))	
		{
			this.transform.Translate(Vector3.up * velocidadDespzamiento);	
		}

		if (Input.GetKey(KeyCode.DownArrow))	
		{
			this.transform.Translate(Vector3.down * velocidadDespzamiento);	
		}
	}
}
*/
