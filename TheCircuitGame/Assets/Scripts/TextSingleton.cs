using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSingleton : MonoBehaviour {

	//public GameObject accuracy;
	public string accuracyText {get; set;}
	private static TextSingleton instance = null;
 	public static TextSingleton Instance {
 	    get { return instance; }
 	}
 	void Awake() {
 	    if (instance != null && instance != this) {
 	        Destroy(this.gameObject);
 	        return;
 	    } else {
 	       instance = this;
		}
 	}
	 void Start() {
		 accuracyText = "Miss";
		 gameObject.SetActive(false);
		 AroundArrowsTriggers.OnNoClick += SetAccuracy;
		 AroundArrowsTriggers.OnNoClick += ActivateText;
		 
		//  ConnectWithArduino.OnClick += SetAccuracy;
		//  ConnectWithArduino.OnClick += ActivateText;
		ArrowMovement.OnClick += SetAccuracy;
		ArrowMovement.OnClick += ActivateText;
	}
	private void ActivateText(){
		gameObject.SetActive(true);
		StartCoroutine(FadeOut.Fade(gameObject, 0.0001f));
		if(accuracyText.Equals("Miss")) {
			GameOverManager.GameOver();}
	}
	private void SetAccuracy(){
		if(!gameObject.activeInHierarchy)
			gameObject.GetComponent<TextMesh>().text = accuracyText;
	}
}
