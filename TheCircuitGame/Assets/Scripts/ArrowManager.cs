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
        countArrows=0;
        speedOfArrows=0.1f;
        waitingTime=2;
        foreach(GameObject arrow in arrows)
            arrow.SetActive(false);
        StartCoroutine("StartNewArrow");
        ConnectWithArduino.OnClick += PlaySound;
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
                ConnectWithArduino.activeArrow = chosenArrow;
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
}