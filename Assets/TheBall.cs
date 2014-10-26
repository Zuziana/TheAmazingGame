using UnityEngine;
using System.Collections;

public class TheBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float minRange = 0f;
		float maxRange = 1f;

		// Randomize 

		if (Mathf.Round(Random.Range (minRange, maxRange)) == 0) {
			// Left
			rigidbody2D.AddForce(new Vector2(80, 10));
		} else {
			// Right
			rigidbody2D.AddForce(new Vector2(-80, -10));
		}

		// Set speed of ball with defined direction

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
