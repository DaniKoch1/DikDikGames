using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAudio : MonoBehaviour {

	AudioClip chosenAudio;
	private static LoadAudio instance = null;
 	public static LoadAudio Instance {
 	    get { return instance; }
 	}
 	void Awake() {
 	    if (instance != null && instance != this) {
 	        Destroy(this.gameObject);
 	        return;
 	    } else {
 	        instance = this;
		 }
		 DontDestroyOnLoad(this);
 	}
	public void StartAudio () {
		if(chosenAudio == null)
			ChooseEarth();
		gameObject.GetComponent<AudioSource>().PlayOneShot(chosenAudio);
	}
	public void ChooseLena(){
		Debug.Log("chosen");
		chosenAudio = Resources.Load<AudioClip>("Lena-BetterNews");
	}
	public void ChooseAristocats(){
		chosenAudio = Resources.Load<AudioClip>("Aristocats");
	}
	public void ChooseEarth(){
		chosenAudio = Resources.Load<AudioClip>("LilDicky-Earth");
	}
}
