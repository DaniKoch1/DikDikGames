using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {
	public Button restartButton;
	private static int missCounter;
	public delegate void NewGameOver(bool over);
	public static event NewGameOver OnGameOver;

	void Start () {
		OnGameOver += ActivateRestartButton;
		ActivateRestartButton(false);
	}
	public static void GameOver(){
		missCounter++;
		if(missCounter == 3){	
			OnGameOver(true);
			missCounter = 0;
        	PlayerPersistance.ResetData();
		}
	}
	public void Restart(){
		OnGameOver(false);
	}
	public void ActivateRestartButton(bool over){
		restartButton.gameObject.SetActive(over);
	}
}
