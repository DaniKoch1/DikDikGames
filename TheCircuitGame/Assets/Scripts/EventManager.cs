using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EventManager : MonoBehaviour {
	private ArrowDirection dir;
	public Text accuracy;
	public delegate void ClickAction();
	public static event ClickAction OnClick;
	void Start() {
		OnClick += SetAccuracy;
		AroundArrowsTriggers.OnNoClick += SetAccuracy;
	}
	private void OnEnable() {
		accuracy.gameObject.SetActive(false);
	}
	void Update () {
		if(Input.anyKeyDown){
			if(!Input.GetButton(dir.ToString()))
				accuracy.text = "Miss";
			if(OnClick != null)
				OnClick();
		}
	}
	private void SetAccuracy () {
		
		accuracy.gameObject.SetActive(true);
	}
}
