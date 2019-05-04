using UnityEngine;
using UnityEngine.UI;

public class BlackArrowTriggers : MonoBehaviour {


	private void OnTriggerEnter2D(Collider2D other) {
		TextSingleton.Instance.accuracyText="Perfect";
		//Debug.Log("Perfect");
	}
	private void OnTriggerExit2D(Collider2D other) {
		TextSingleton.Instance.accuracyText="Good";
		//Debug.Log("Good");
	}
}
