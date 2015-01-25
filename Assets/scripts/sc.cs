
using UnityEngine;
using System.Collections;

public class sc : MonoBehaviour {
	
	public float maxspeed = 10f;
	Animator anim;
	public Texture btnTexture;
	
	bool faceRight = true;
	public float Respawntime=1.0f;
	public float acel=65f;
	public float speedFactor=25;
	

	public GameObject botellaBuena;
	public GameObject botellaBuena2;
	public GameObject botellaBuena3;
	public GameObject botellaBuena4;
	public GameObject botellaBuena5;
	public GameObject botellaBuena6;
	public GameObject botellaMala;
	
	// Use this for initialization
	void Start () {
		//se llama al animator del personaje
		anim = GetComponent<Animator> ();
		this.gameObject.transform.position = new Vector2 (-23, -1.5f);
	}
	
	
	
	void FixedUpdate() {
		{
			if (this.gameObject.transform.position.x >= 70)
				Application.LoadLevel ("Escena7_Panal");
				//this.gameObject.transform.position= new Vector2(29,-1.50f);
			if (this.gameObject.transform.position.x <= -34)
				this.gameObject.transform.position = new Vector3 (-34, -1.5f);
				//flores.transform.Translate
		}
		float move = Input.GetAxis ("Horizontal");
		anim.SetFloat ("Speed",Mathf.Abs(move));
		rigidbody2D.velocity = new Vector2 (move*maxspeed, rigidbody2D.velocity.y);
		
		if (move > 0 &&! faceRight)
			Flip ();
		else if(move < 0 && faceRight)
			Flip ();

		if (botellaBuena != null && this.gameObject.transform.position.x >= -6.0f) {
						botellaBuena.transform.Translate (speedFactor * Time.deltaTime * acel * Vector3.down * 3.9f);}
		if (botellaBuena2 != null && this.gameObject.transform.position.x >= 31.0f)
						botellaBuena2.transform.Translate(speedFactor * Time.deltaTime * acel*Vector3.down*3.9f);
		if (botellaBuena3 != null && this.gameObject.transform.position.x >= -12.0f)
						botellaBuena3.transform.Translate(speedFactor * Time.deltaTime * acel*Vector3.down*3.9f);
		if (botellaBuena4 != null && this.gameObject.transform.position.x >= 8.0f)
						botellaBuena4.transform.Translate(speedFactor * Time.deltaTime * acel*Vector3.down*3.9f);
		if (botellaBuena5 != null && this.gameObject.transform.position.x >= -36.0f)
						botellaBuena5.transform.Translate(speedFactor * Time.deltaTime * acel*Vector3.down*3.9f);
		if (botellaBuena6 != null && this.gameObject.transform.position.x >= 36.0f)
						botellaBuena6.transform.Translate(speedFactor * Time.deltaTime * acel*Vector3.down*3.9f);
		if (botellaMala != null && this.gameObject.transform.position.x >= 58)
						botellaMala.transform.Translate(speedFactor * Time.deltaTime * acel*Vector3.down*3.9f);



		if (botellaBuena != null && botellaBuena.transform.position.y <= 0)
						botellaBuena.transform.position = new Vector3 (3.0f, -1.5f,-1);
		if (botellaBuena2 != null && botellaBuena2.transform.position.y <= 0)
			botellaBuena2.transform.position = new Vector3 (29.0f, -1.8f,-1);
		if (botellaBuena3 != null && botellaBuena3.transform.position.y <= 0)
			botellaBuena3.transform.position = new Vector3 (-13.0f, -1.5f,-1);
		if (botellaBuena4 != null && botellaBuena4.transform.position.y <= 0)
			botellaBuena4.transform.position = new Vector3 (16.0f, -1.8f,-1);
		if (botellaBuena5 != null && botellaBuena5.transform.position.y <= 0)
			botellaBuena5.transform.position = new Vector3 (-35.14032f, -1.8f,-1);
		if (botellaBuena6 != null && botellaBuena6.transform.position.y <= 0)
			botellaBuena6.transform.position = new Vector3 (43f, -1.8f,-1);
		if (botellaMala != null && botellaMala.transform.position.y <= 0)
			botellaMala.transform.position = new Vector3 (55.0f, -1.5f,-1);


	

	}
	void Flip(){
		faceRight = !faceRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	// death from falling

	void OnCollisionEnter2D(Collision2D coll) {
			if (coll.gameObject.tag == "botellabuena") {
						Destroy (coll.gameObject);
				}
		if (coll.gameObject.tag == "botellabuena2") {
						Destroy (coll.gameObject);
				}
		if (coll.gameObject.tag == "botellabuena3") {
						Destroy (coll.gameObject);
				}
		if (coll.gameObject.tag == "botellabuena4") {
						Destroy (coll.gameObject);
				}
		if (coll.gameObject.tag == "botellabuena5") {
						Destroy (coll.gameObject);
				}
		if (coll.gameObject.tag == "botellabuena6") {
						Destroy (coll.gameObject);
				}
		if (coll.gameObject.tag == "botellamala") {
			Destroy (coll.gameObject);
		}
			//if (coll.gameObject.tag == "botellabuena2")
			//			Destroy (this.gameObject);
		
	}
}