using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCaller : MonoBehaviour {

	public GameObject[] arrows;
	public float speed = 0.1f;
	private int activeArrow;
	void Start () {
		ChooseArrow();
	}
	
	void Update () {
		MoveArrow(arrows[activeArrow], speed);
	}
	private void ChooseArrow(){
		activeArrow = Random.Range(0,4);
	}
	public void MoveArrow(GameObject arrow, float speed){
		arrow.transform.Translate(Vector2.down * speed);
	}
}
