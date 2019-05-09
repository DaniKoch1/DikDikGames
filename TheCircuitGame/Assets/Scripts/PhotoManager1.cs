using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoManager1 : MonoBehaviour {

	public GameObject[] photos;
	public Button done;
	private int count;
	void Start () {
		foreach(GameObject g in photos)
			g.SetActive(false);
		photos[0].SetActive(true);
		count = 0;
		done.gameObject.SetActive(false);
	}
	
	public void ActivateNext(){
		photos[count].SetActive(false);
		if(count==6){
			count=0;
			done.gameObject.SetActive(true);
		}
		else
			count++;
		photos[count].SetActive(true);
	}
	public void ActivatePrevious(){
		photos[count].SetActive(false);
		if(count==0)
			count=6;
		else
			count--;
		photos[count].SetActive(true);
	}
}
