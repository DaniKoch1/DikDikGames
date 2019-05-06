using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	private static int missCounter;
	private float speedOfArrows;
	public AudioSource music;
	public void StartGame(){
		SceneManager.LoadScene("Dance");
	}
	public void PauseGame(){
		Time.timeScale = Time.timeScale == 1.0f ? 0.0f : 1.0f;
		if(ArrowManager.speedOfArrows == 0){
			music.Play(0);
			ArrowManager.speedOfArrows = speedOfArrows;
		}
		else{
			music.Pause();
			speedOfArrows = ArrowManager.speedOfArrows;
			ArrowManager.speedOfArrows = 0;
		}
	}
	public void QuitGame(){
		#if UNITY_EDITOR
        	UnityEditor.EditorApplication.isPlaying = false;
		#else
        	Application.Quit ();
		#endif
	}
	public static void GameOver(){
		missCounter++;
		if(missCounter == 10)
		{
			SceneManager.LoadScene("GameOver");
        	//PlayerPersistance.ResetData();
		}
	}
}
