using UnityEngine;
using UnityEngine.UI;

public class BlackArrowTriggers : MonoBehaviour {

	public Text accuracy;
	private void OnTriggerEnter2D(Collider2D other) {
		accuracy.text="Perfect";
	}
	private void OnTriggerExit2D(Collider2D other) {
		accuracy.text="Good";
	}
}
