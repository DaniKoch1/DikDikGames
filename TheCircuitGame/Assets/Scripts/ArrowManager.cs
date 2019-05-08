using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrowManager : MonoBehaviour{

    public GameObject[] arrows;
    public AudioClip tone;
    private int countArrows;
    public static float waitingTime;
    public static float speedOfArrows;
    void Start() {
        Reset(false);
        foreach(GameObject arrow in arrows)
            arrow.SetActive(false);
        StartCoroutine("StartNewArrow");
        waitingTime = 2;
        speedOfArrows = 0.1f;
        //ConnectWithArduino.OnClick += PlaySound;
        ArrowMovement.OnClick += PlaySound;
        GameOverManager.OnGameOver += StopNewArrow;
        GameOverManager.OnGameOver += Reset;

    }
    void OnEnable() {
        PlayerPersistance.LoadData();
    }
    void OnDisable() {
        PlayerPersistance.SaveData();
    }
    private IEnumerator StartNewArrow(){
        GameObject chosenArrow;
        while(true){
            countArrows++;
            if(countArrows%4==0)
                speedOfArrows+=0.01f;
            chosenArrow = ChooseArrow();
            if(!chosenArrow.activeInHierarchy){
                chosenArrow.SetActive(true);
		        //TextSingleton.Instance.accuracyText = "Miss";
                //ConnectWithArduino.activeArrow = chosenArrow;
                if(countArrows%3==2 && waitingTime>=0.05f)
                    waitingTime-=0.05f;
                yield return new WaitForSeconds(waitingTime);
            }
        }
    }
    private GameObject ChooseArrow(){
        return arrows[Random.Range(0,4)];
	}
    private void PlaySound(){
        GetComponent<AudioSource>().PlayOneShot(tone, 1f);
    }
    public void StopNewArrow(bool over){
        if(over)
            StopCoroutine("StartNewArrow");
        else
            StartCoroutine("StartNewArrow");
    }
    public void Reset(bool over){
        if(!over){
            countArrows=0;
            PlayerPersistance.LoadData();
            ScoreManager.Instance.ResetScore();
        }
    }
}