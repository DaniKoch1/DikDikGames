using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	private static int missCounter;
	public void StartGame(){
		SceneManager.LoadScene("Dance");
	}
	public void PauseGame(){
		Time.timeScale = Time.timeScale == 1.0f ? 0.0f : 1.0f;
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
        	PlayerPersistance.ResetData();
		}
	}
}
