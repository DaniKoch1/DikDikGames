using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {

	public float speed; //get from GameManager: with points and number of catches (static there), set in OnEnable
	void OnEnable() {
		transform.position = new Vector2(transform.position.x, 6);
		speed = 0.1f;
	}
	void Update () {
		MoveArrow();
	}
	private void MoveArrow(){
		transform.Translate(Vector2.down * speed);
	}
	private void StopArrow(){
		speed = 0;
	}
}
