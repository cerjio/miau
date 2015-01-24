using UnityEngine;
using System.Collections;


public class MoverCarros : MonoBehaviour {
	public float velocidad;
	public int tipoV,pasos;
	public float posIni;
	// Use this for initialization
	void Start () {
		posIni = 4;
		tipoV = Random.Range (1, 6);
		pasos = 0;

	
	}
	
	// Update is called once per frame
	void Update () {

		switch (tipoV) 
			
		{
		case 1:
			velocidad=0.05f;
			break;
		case 2:
			velocidad=0.04f;
			break;
		case 3:
			velocidad=0.08f;
			break;
		case 4:
			velocidad=0.03f;
			break;
		case 5:
			velocidad=0.09f;
			break;
		case 6:
			velocidad=0.14f;
			break;
			
		}
		if (gameObject.tag == "CarroArriba1") {
	
						if (this.transform.position.y <= -6) {
			
								this.transform.Translate (Vector3.down * velocidad * -pasos);
								pasos = 0;
								tipoV = Random.Range (1, 6);
						} else {
								this.transform.Translate (Vector3.down * velocidad);
								pasos += 1;
								Debug.Log (this.transform.position.y);
						}
		} if (gameObject.tag == "CarroAbajo") 
		{
			
			if (this.transform.position.y >= 6) {
				
				this.transform.Translate (Vector3.down * velocidad * pasos);
				pasos = 0;
				tipoV = Random.Range (1, 6);
			} else {
				this.transform.Translate (Vector3.up * velocidad);
				pasos += 1;
				Debug.Log (this.transform.position.y);
			}
				}
		
	}

	void OnCollisionEnter2D(Collision2D col)

	{
		Destroy (col.gameObject);
	}
}

