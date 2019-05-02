﻿using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public Text accuracy;
	void Start () {
		accuracy.gameObject.SetActive(false);
		EventManager.OnClick += SetAccuracy;
		AroundArrowsTriggers.OnNoClick += SetAccuracy;
	}
	
	void SetAccuracy () {
		if(!Input.GetButton(gameObject.tag))
			accuracy.text = "Miss";
		accuracy.gameObject.SetActive(true);
	}
}
