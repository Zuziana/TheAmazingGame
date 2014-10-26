using UnityEngine;
using System.Collections;

public class TheBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float minRange = 0f;
		float maxRange = 1f;

		if (Mathf.Round(Random.Range (minRange, maxRange)) == 0) {
			// Left
			rigidbody2D.AddForce(new Vector2(40, 5));
		} else {
			// Right
			rigidbody2D.AddForce(new Vector2(-40, -5));
		}	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D colInfo ) {
		Vector2 newForce;

		if (colInfo.collider.tag == "Player")
		{
			newForce = rigidbody2D.velocity;
			newForce.y = rigidbody2D.velocity.y / 2 + colInfo.collider.rigidbody2D.velocity.y / 3;
			rigidbody2D.velocity = newForce;
		}
	}
}
