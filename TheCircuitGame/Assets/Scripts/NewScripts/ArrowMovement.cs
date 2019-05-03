using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {
	private ArrowDirection dir;
	public GameObject particle; 
	public float speed; //get from GameManager: with points and number of catches (static there), set in OnEnable
	void OnEnable() {
		transform.position = new Vector2(transform.position.x, 6);
		
		speed = 0.1f;
	}
	void Update () {
		MoveArrow();
		if(Input.anyKeyDown){
			//if(!Input.GetButton(dir.ToString()))
				//accuracy.text = "Miss";
			//StartCoroutine("DisapearArrowWithParticle");
			DisapearArrowWithParticle();
		}
	}
	private void MoveArrow(){
		transform.Translate(Vector2.down * speed);
	}
	// public IEnumerator DisapearArrowWithParticle(){
	// 	Instantiate(particle, transform);
	// 	yield return new WaitForSeconds(0.5f);
	// 	gameObject.SetActive(false);
	// }
	public void DisapearArrowWithParticle(){
		Instantiate(particle, transform);
		StartCoroutine(FadeOut.Fade(gameObject));
		//gameObject.SetActive(false);
	}
}
