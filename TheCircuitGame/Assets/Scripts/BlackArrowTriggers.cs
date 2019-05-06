using UnityEngine;
using UnityEngine.UI;

public class BlackArrowTriggers : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D other) {
		TextSingleton.Instance.accuracyText="Perfect";
		ScoreManager.Instance.score=15;
	}
	private void OnTriggerExit2D(Collider2D other) {
		TextSingleton.Instance.accuracyText="Good";
		ScoreManager.Instance.score=10;
	}
}
