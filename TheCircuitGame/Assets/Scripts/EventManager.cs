using UnityEngine;

public class EventManager : MonoBehaviour {

	public delegate void ClickAction();
	public static event ClickAction OnClick;
	void Update () {
		if(Input.anyKeyDown){
			if(OnClick != null)
				OnClick();
		}
	}
}
