using UnityEngine;
using System.Collections;

public class MegamanControllerScript : MonoBehaviour {

	public float maxspeed = 10f;
	Animator anim;
	bool faceRight = true;
	public float Respawntime=1.0f;
	public float acel=1;
	public float speedFactor=5;



	// Use this for initialization
	void Start () {
		//se llama al animator del personaje
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.UpArrow))	
		{
			Application.LoadLevel("Escena7_Panal");
		}
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
	void OnCollisionEnter(Collision collision) 
	{
		if(gameObject.tag=="bullet")
		{
			this.gameObject.transform.position=new Vector2 (Screen.width/3,Screen.height/2);
			//healthScript.health -= 1;
		}

		else if(gameObject.tag=="cambioEscena");//(gameObject.tag=="cambioEscena")
		{
			Application.LoadLevel("Escena7_Panal");
		}
	}

}