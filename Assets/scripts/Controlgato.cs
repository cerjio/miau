using UnityEngine;
using System.Collections;

public class Controlgato : MonoBehaviour {
	Vector3 scalar;
	// Use this for initialization
	void Start () {
		scalar = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(Vector3.up * .01f);

			scalar.x += -.0023f;
			scalar.y += -.0023f;
			this.transform.localScale=scalar;
			if(this.transform.localScale.y<=.9 && this.transform.localScale.y>.6)
			{
				this.gameObject.renderer.sortingOrder=5;
			}
			if(this.transform.localScale.y<=.6 && this.transform.localScale.y>.46)
			{
				this.gameObject.renderer.sortingOrder=4;
			}
			if(this.transform.localScale.y<=.46 && this.transform.localScale.y>.35)
			{
				this.gameObject.renderer.sortingOrder=3;
			}
			if(this.transform.localScale.y<=.35)
			{
				this.gameObject.renderer.sortingOrder=2;
			}

		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(Vector3.down * .01f);
			scalar.x += .0023f;
			scalar.y += .0023f;
			this.transform.localScale=scalar;
		}
	}
}
