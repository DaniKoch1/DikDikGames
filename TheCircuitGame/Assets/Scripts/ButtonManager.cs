using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	private float speedOfArrows;
	private AudioSource music;
	public static event GameOverManager.NewGameOver OnPause;
	void Start() {
		music = LoadAudio.Instance.audioSource;
	}
	public void StartGame(){
		SceneManager.LoadScene("Dance");
	}
	public void PauseGame(){
		Time.timeScale = Time.timeScale == 1.0f ? 0.0f : 1.0f;
		if(ArrowManager.speedOfArrows == 0){
			ArrowManager.speedOfArrows = speedOfArrows;
			OnPause(false);
			music.UnPause();
		}
		else{
			music.Pause();
			speedOfArrows = ArrowManager.speedOfArrows;
			ArrowManager.speedOfArrows = 0;
			OnPause(true);
		}
	}
	public void QuitGame(){
		#if UNITY_EDITOR
        	UnityEditor.EditorApplication.isPlaying = false;
		#else
        	Application.Quit ();
		#endif
	}
	
}
