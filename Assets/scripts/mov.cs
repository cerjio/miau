using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {


	public float velocidadDespzamiento;
	public float velocidadGiro;

	public Transform fondo;

	// Use this for initialization
	void Start () {
		fondo = GameObject.FindGameObjectWithTag("fondo1").transform; 
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow))	
		{
			this.transform.Translate(Vector3.left * velocidadDespzamiento);


			fondo.Translate(Vector3.left * velocidadDespzamiento);
			//
		}

		if (Input.GetKey(KeyCode.RightArrow))	
		{
			this.transform.Translate(Vector3.right * velocidadDespzamiento);	
		}
	}
}
