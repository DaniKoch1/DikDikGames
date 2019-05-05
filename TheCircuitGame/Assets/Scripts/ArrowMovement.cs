﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {
	public ArrowDirection dir;
	public GameObject particle; 
	public float speed; //get from GameManager: with points and number of catches (static there), set in OnEnable
	public static event AroundArrowsTriggers.ClickAction OnClick;
	void OnEnable() {
		transform.position = new Vector2(transform.position.x, 6);
	}
	private void Start() {
		OnClick += DisapearArrowWithParticle;
	}
	void Update () {
		MoveArrow();
		if(Input.anyKeyDown){
			if(!Input.GetButton(dir.ToString()))
				TextSingleton.Instance.accuracyText = "Miss";
			OnClick();
		}
	}
	private void MoveArrow(){
		transform.Translate(Vector2.down * speed);
	}
	public void DisapearArrowWithParticle(){
		if(gameObject.activeSelf){
			Instantiate(particle, transform);
			StartCoroutine(FadeOut.Fade(gameObject));
		}
	}
}
