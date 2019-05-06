using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public int score{get; set;}
	public int totalScore {get; set;}
	public int highscore {get; set;}
	public GameObject newHighscore;
	public GameObject displayedHighscore;
	private static ScoreManager instance = null;
 	public static ScoreManager Instance {
 	    get { return instance; }
 	}
	 private bool firstHighscore = true;
 	void Awake() {
 	    if (instance != null && instance != this) {
 	        Destroy(this.gameObject);
 	        return;
 	    } else {
 	        instance = this;
		 }
		 //DontDestroyOnLoad(this);
 	}
	void Start() {
		 //displayedScore=GameObject.Find("Score");
		 //displayedHighscore=GameObject.Find("Highscore");
		 ConnectWithArduino.OnClick += SetScore;
		 displayedHighscore.GetComponent<TextMesh>().text = "Highscore: " + highscore.ToString();
		 newHighscore.SetActive(false);
	 }

	public void SetScore(){
		//displayedScore=GameObject.Find("Score");
		totalScore+=score;
		gameObject.GetComponent<TextMesh>().text = "Score: " + totalScore.ToString();
		if(totalScore > highscore)
		{
			if(firstHighscore){
				newHighscore.SetActive(true);
				StartCoroutine(FadeOut.Fade(newHighscore, 0.001f));
				firstHighscore = false;
			}
			highscore = totalScore;
		}
	}
}
