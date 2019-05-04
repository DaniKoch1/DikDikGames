using UnityEngine;
using UnityEngine.UI;

public class AroundArrowsTriggers : MonoBehaviour {

	private Collider2D arrow;
	//private string accuracy;
	public delegate void ClickAction();
	public static event ClickAction OnNoClick;
	private void Start() {
		OnNoClick += StartFading;
	}
	private void OnTriggerEnter2D(Collider2D other) {
		TextSingleton.Instance.accuracyText="Good";
		ScoreManager.Instance.score=10;
		//Debug.Log("Good");
	}
	private void OnTriggerExit2D(Collider2D other) {
		TextSingleton.Instance.accuracyText="Miss";
		ScoreManager.Instance.score=0;
		//Debug.Log("Miss");
		arrow=other;
		if(OnNoClick != null)
			OnNoClick();
	}
	private void StartFading(){
		StartCoroutine(FadeOut.Fade(arrow.gameObject));
	}
}
