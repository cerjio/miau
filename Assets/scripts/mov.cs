using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {


	public float velocidadDespzamiento;
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
