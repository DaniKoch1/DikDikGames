using UnityEngine;
using UnityEngine.UI;

public class AroundArrowsTriggers : MonoBehaviour {

	private Collider2D arrow;
	public delegate void ClickAction();
	public static event ClickAction OnNoClick;
	public Text accuracy;
	private void Start() {
		OnNoClick += StartFading;
	}
	private void OnTriggerEnter2D(Collider2D other) {
		accuracy.text="Good";
	}
	private void OnTriggerExit2D(Collider2D other) {
		accuracy.text="Miss";
		arrow=other;
		OnNoClick();
	}
	private void StartFading(){
		StartCoroutine(FadeOut.Fade(arrow.GetComponent<SpriteRenderer>()));
	}
}
