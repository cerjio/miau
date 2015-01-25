using UnityEngine;
using System.Collections;

public class CambiarEscena : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void Update(){
		Debug.Log(Application.loadedLevelName);
		
		if(Application.loadedLevelName == "Escena1_perro" && this.transform.position.x >= 10){
			Application.LoadLevel("Escena2_Atropellado");
		}
		
		else if(Application.loadedLevelName == "Escena2_Atropellado" && this.transform.position.x >= 10){
			Application.LoadLevel("Escena3_piano");
		}
		
		else if(Application.loadedLevelName == "Escena3_piano" && this.transform.position.x >= 10){
			Application.LoadLevel("Escena4_lata");
		}

		else if(Application.loadedLevelName == "Escena4_lata" && this.transform.position.x >= 10){
			Application.LoadLevel("Escena5_panal");
		}
		
		else if(Application.loadedLevelName == "Escena5_panal" && this.transform.position.x >= 10){
			Application.LoadLevel("Escena6_caminos");
		}
		
		else if(Application.loadedLevelName == "Escena6_caminos" && this.transform.position.x >= -2){
			Application.LoadLevel("Escena7_Panal");
		}
		
		else if(Application.loadedLevelName == "Escena7_Panal" && this.transform.position.x >= -2){
			Debug.Log("dgfyds");
			Application.LoadLevel("Escena1_perro");
		}
	}
}
