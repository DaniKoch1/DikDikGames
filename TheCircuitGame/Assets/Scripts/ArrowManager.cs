using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {

	public GameObject[] arrows;
	public float speed = 0.1f;
	public float tempSpeed;
	private int activeArrow;
	void Start () {
		foreach(GameObject arrow in arrows)
			arrow.SetActive(false);
		StartCoroutine("StartArrow");
		EventManager.OnClick += ToggleSpeed;
		//EventManager.OnClick += ResetArrow;
	}
	void OnEnable() {
		tempSpeed = speed;
	}
	void Update () {
		MoveArrow(arrows[activeArrow], tempSpeed);
	}
	private void ChooseArrow(){
		activeArrow = Random.Range(0,4);
		arrows[activeArrow].SetActive(true);
	}
	private void MoveArrow(GameObject arrow, float speed){
		arrow.transform.Translate(Vector2.down * speed);
	}
	private void ToggleSpeed(){
		tempSpeed = tempSpeed != 0 ? 0 : speed;
		Invoke("ResetArrow", 0.1f);
		
	}
	private void ResetArrow(){
		arrows[activeArrow].transform.position = new Vector3(arrows[activeArrow].transform.position.x, 10.5f, arrows[activeArrow].transform.position.z);
	}
	private IEnumerator StartArrow(){
		while(true){
			ChooseArrow();
			yield return new WaitForSeconds(2);
			//ToggleSpeed();
		}
	}

}
