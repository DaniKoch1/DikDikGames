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
		//  ConnectWithArduino.OnClick += SetScore;
		 ArrowMovement.OnClick += SetScore;
		 GameOverManager.OnGameOver += ChangePositions;
		 //GameOverManager.OnGameOver += ActivateNewHighScore;
		 UpdateHighScore(true);
		 newHighscore.SetActive(false);
	 }

	public void SetScore(){
		totalScore+=score;
		gameObject.GetComponent<TextMesh>().text = "Score: " + totalScore.ToString();
		if(totalScore > highscore)
		{
			if(firstHighscore){
				ActivateNewHighScore(true);
				StartCoroutine(FadeOut.Fade(newHighscore, 0.001f));
				GameOverManager.OnGameOver += ActivateNewHighScore;
				GameOverManager.OnGameOver += UpdateHighScore;
			}
			highscore = totalScore;
		}
	}
	public void ResetScore(){
		totalScore = 0;
		score = 0;
		firstHighscore = true;
		GameOverManager.OnGameOver -= ActivateNewHighScore;
		GameOverManager.OnGameOver -= UpdateHighScore;
		SetScore();
	}
	public void ActivateNewHighScore(bool over){
		newHighscore.SetActive(over);
		firstHighscore = !over;	
	}
	public void UpdateHighScore(bool over){
		 displayedHighscore.GetComponent<TextMesh>().text = "Highscore: " + highscore.ToString();
	}
	public void ChangePositions(bool over){
		if(over){
			gameObject.transform.position = new Vector3(0,3.8f,1);
			displayedHighscore.transform.position = new Vector3(0,3,1);
		}
		else{
			gameObject.transform.position = new Vector3(-7.5f,4.5f,1);
			displayedHighscore.transform.position = new Vector3(-7.5f,4,1);
		}
	}
}
