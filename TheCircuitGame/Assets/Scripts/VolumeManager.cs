using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour {

	
	public Slider slider;
	//public Canvas pauseMenu;
	private AudioSource music;
	void Start () {
		gameObject.SetActive(false);
		music = LoadAudio.Instance.audioSource;
		ButtonManager.OnPause += ActivatePauseMenu;
	}
	public void ChangeVolum(){
		music.volume = slider.value;
	}
	public void ActivatePauseMenu(bool pause){
		gameObject.SetActive(pause);
	}
}
