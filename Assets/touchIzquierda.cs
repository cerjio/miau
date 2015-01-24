using UnityEngine;
using System.Collections;

public class touchIzquierda : MonoBehaviour {
	public Texture btnTexture;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {

		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,btnTexture.width,btnTexture.height), btnTexture)) {
			Debug.Log("izq");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,btnTexture.width,btnTexture.height),btnTexture )) {
			Debug.Log("der");
		}
	}
}
