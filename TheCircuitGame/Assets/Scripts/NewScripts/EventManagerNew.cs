using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventManagerNew : MonoBehaviour{

    public GameObject[] arrows;
    void Start() {
        foreach(GameObject arrow in arrows)
            arrow.SetActive(false);
        StartCoroutine("StartNewArrow");
    }
    private IEnumerator StartNewArrow(){
        GameObject chosenArrow;
        while(true){
            chosenArrow = ChooseArrow();
            if(!chosenArrow.activeInHierarchy){
                chosenArrow.SetActive(true);
                Debug.Log("Chosen New: "+chosenArrow.name);
                yield return new WaitForSeconds(2);
            }
        }
    }
    private GameObject ChooseArrow(){
        return arrows[Random.Range(0,4)];
	}
}