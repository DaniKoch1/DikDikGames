using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public int score{get; set;}
	private int totalScore;
	private static ScoreManager instance = null;
 	public static ScoreManager Instance {
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
		 ArrowMovement.OnClick += SetScore;
	 }

	public void SetScore(){
		totalScore+=score;
		gameObject.GetComponent<TextMesh>().text = "Score: " + totalScore.ToString();
	}
}
