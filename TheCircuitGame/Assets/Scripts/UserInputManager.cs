using UnityEngine;
using UnityEngine.UI;

public class UserInputManager : MonoBehaviour {

	public Text accuracy;
	void Start () {
		accuracy.gameObject.SetActive(false);
	}
	
	void Update () {
		if(Input.anyKey){
			if(!Input.GetButton(gameObject.tag))
				accuracy.text = "miss";
			accuracy.gameObject.SetActive(true);
		}
	}
}
