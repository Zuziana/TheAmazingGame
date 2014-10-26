using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	Vector2 newVector;
	
	public KeyCode moveUp;
	
	public KeyCode moveDown;

	public KeyCode moveRight;
	
	public KeyCode moveLeft;

	public float maxSpeed = 10;

	public float acceleration = 0.1f;

	// Update is called once per frame
	void Update () {
		newVector = rigidbody2D.velocity;
		
		if(Input.GetKey(moveUp)){
			newVector.y = newVector.y + this.acceleration;
		}
		else if(Input.GetKey(moveDown)){
			newVector.y = newVector.y - this.acceleration;
		}
		else if(Input.GetKey(moveLeft)){
			// newVector.x = newVector.x - this.acceleration;
		}
		else if(Input.GetKey(moveRight)){
			// newVector.x = newVector.x + this.acceleration;
		}
		
		rigidbody2D.velocity = newVector;
	}
}
