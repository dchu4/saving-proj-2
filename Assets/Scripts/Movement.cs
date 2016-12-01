using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	public float jumpForce;
	bool canJump = true;

	// Update is called once per frame
	void Update () {
		if (Input.acceleration.x < -0.115f) {
			moveLeft ();
		} else if (Input.acceleration.x > 0.115f) {
			moveRight ();
		} 

		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				jump ();
			}
		}
	}

	void moveLeft(){
		rb.AddForce (new Vector2 (-speed, 0));
	}

	void moveRight(){
		rb.AddForce (new Vector2 (speed, 0));
	}

	void moveForward(){
		rb.AddForce (new Vector2 (0, speed));
	}

	void moveBackward(){
		rb.AddForce (new Vector2 (0, -speed));
	}

	void stopMovement(){
		rb.velocity = Vector2.zero;
	}

	public void jump(){
		if (canJump == true) {
			rb.AddForce (new Vector2 (0, jumpForce));
			canJump = false;
			Debug.Log ("HOP!");
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Platform") {
			canJump = true;
		}
	}
}
