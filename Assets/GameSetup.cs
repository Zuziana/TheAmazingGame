using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	public Camera mainCamera;

	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	// Update is called once per frame
	void Update () {
		// Sizes
		topWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f); 
		bottomWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f); 
		rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y); 
		leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y); 

		// Locations
		topWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
		bottomWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
		rightWall.center = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
		leftWall.center = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
	}
}
