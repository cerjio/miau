using UnityEngine;
using System.Collections;

public class DestroyByCollision : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		// If you want to check who you collided with,
		// you should typically use tags, not names.
		if (collision.gameObject.tag == "bullet") {
				Destroy (this.gameObject);
		}
	}
}