using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	public BoxCollider2D TopWall;
	public BoxCollider2D BottomWall;
	public BoxCollider2D LeftWall;
	public BoxCollider2D RightWall;

	// Update is called once per frame
	void Update () {
		// Sizes
		TopWall.size = new Vector2( 0f, 0f);

		// Locations
		TopWall.center = new Vector2 (0f, 0f);
	}
}
