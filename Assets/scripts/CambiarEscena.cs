using UnityEngine;
using System.Collections;

public class CambiarEscena : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void Update(){
		Debug.Log(this.transform.position.x);

		if(this.transform.position.x >= 10){
			Application.LoadLevel("Escena7_Panal");
		}
	}
}
