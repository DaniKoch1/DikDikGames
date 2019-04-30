using UnityEngine;
using UnityEngine.UI;

public class AroundArrowsTriggers : MonoBehaviour {

	public Text accuracy;
	private void OnTriggerEnter2D(Collider2D other) {
		accuracy.text="Good";
		Debug.Log("Good");
	}
	private void OnTriggerExit2D(Collider2D other) {
		accuracy.text="Miss";
		Debug.Log("Miss");
	}
}
