using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {
	public ArrowDirection dir{get; private set;}
	public GameObject particle; 
	void OnEnable() {
		transform.position = new Vector2(transform.position.x, 6);
	}
	private void Start() {
		ConnectWithArduino.OnClick += DisapearArrowWithParticle;
	}
	void Update () {
		MoveArrow();
		// if(Input.anyKeyDown){
		// 	if(!Input.GetButton(dir.ToString())){
		// 		TextSingleton.Instance.accuracyText = "Miss";
		// 		ScoreManager.Instance.score = 0;
		// 	}
		// 	if(Input.GetButton("Left") || Input.GetButton("Right") || Input.GetButton("Up") || Input.GetButton("Down"))
		// 		OnClick();
		// }
	}
	private void MoveArrow(){
		transform.Translate(Vector2.down * ArrowManager.speedOfArrows);
	}
	public void DisapearArrowWithParticle(){
		if(gameObject.activeSelf){
			Instantiate(particle, transform);
			StartCoroutine(FadeOut.Fade(gameObject, 0.0001f));
		}
	}
	// public void ListenToInput(ArrowDirection button){
	// 	if(button != dir){
	// 		TextSingleton.Instance.accuracyText = "Miss";
	// 		ScoreManager.Instance.score = 0;
	// 	}
	// 	OnClick();
	// }
}
