using UnityEngine;
using System.Collections;


public class MoverCarros : MonoBehaviour {
	public float velocidad;
	public int tipoV,pasos;
	public float posIni;
	public GameObject player;
	public Rigidbody2D gc;

	// Use this for initialization
	void Start () {
		posIni = 4;
		tipoV = Random.Range (1, 6);
		pasos = 0;
		player=GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		switch (tipoV) 
			
		{
		case 1:
			velocidad=0.07f;
			break;
		case 2:
			velocidad=0.06f;
			break;
		case 3:
			velocidad=0.1f;
			break;
		case 4:
			velocidad=0.11f;
			break;
		case 5:
			velocidad=0.13f;
			break;
		case 6:
			velocidad=0.18f;
			break;
			
		}
		
		
		if (this.transform.position.x >=11) {
			
			this.transform.Translate (Vector3.right * velocidad * -pasos);
			pasos = 0;
			tipoV = Random.Range (1, 6);
		} else {
			this.transform.Translate (Vector3.right * velocidad);
			pasos += 1;
			
		}
		
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
		
	{

		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			Application.LoadLevel("Escena1_perro");
				}
			

				
	}
}

