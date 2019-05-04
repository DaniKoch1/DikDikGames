using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSingleton : MonoBehaviour {

	public GameObject accuracy;
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
		 accuracy.gameObject.SetActive(false);
		 AroundArrowsTriggers.OnNoClick += SetAccuracy;
		 AroundArrowsTriggers.OnNoClick += ActivateText;
		 
		 ArrowMovement.OnClick += SetAccuracy;
		 ArrowMovement.OnClick += ActivateText;
	}
	private void ActivateText(){
		accuracy.gameObject.SetActive(true);
		StartCoroutine(FadeOut.Fade(accuracy.gameObject));
	}
	private void SetAccuracy(){
		if(!accuracy.activeInHierarchy)
			accuracy.GetComponent<TextMesh>().text = accuracyText;
	}
}
