using UnityEngine;
using System.Collections;

public class Controles : MonoBehaviour {
	public Texture btnTexture;
	public GameObject player;
	public float speed;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		
		if (!btnTexture) {

			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		


		while (GUI.RepeatButton(new Rect(5,Screen.height-(btnTexture.height/4),btnTexture.width/4,btnTexture.height/4), btnTexture) ){
			Input.GetKeyUp(KeyCode.LeftArrow);

		}
		
		// Make the second button.
		while (GUI.RepeatButton(new Rect((btnTexture.width/4)+5,Screen.height-(btnTexture.height/4),btnTexture.width/4,btnTexture.height/4),btnTexture ) ){
			Input.GetKeyUp(KeyCode.LeftArrow);
			
		}
	}
}
