using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {

	public GameObject[] arrows;
	public float speed = 0.1f;
	public float tempSpeed;
	private int activeArrow;
	void Start () {
		tempSpeed = speed;
		foreach(GameObject arrow in arrows)
			arrow.SetActive(false);
		ChooseArrow();
		EventManager.OnClick += ToggleSpeed;
		//EventManager.OnClick += ResetArrow;
	}
	
	void Update () {
		MoveArrow(arrows[activeArrow], tempSpeed);
	}
	private void ChooseArrow(){
		activeArrow = Random.Range(0,4);
		arrows[activeArrow].SetActive(true);
	}
	public void MoveArrow(GameObject arrow, float speed){
		arrow.transform.Translate(Vector2.down * speed);
	}
	public void ToggleSpeed(){
		tempSpeed = tempSpeed != 0 ? 0 : speed;
		Invoke("ResetArrow", 1f);
	}
	public void ResetArrow(){
		arrows[activeArrow].transform.position = new Vector3(arrows[activeArrow].transform.position.x, 10.5f, arrows[activeArrow].transform.position.z);
	}

}
