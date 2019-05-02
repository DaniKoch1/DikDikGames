using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour {
	private ArrowDirection dir;
	public Text accuracy;
	public delegate void ClickAction();
	public static event ClickAction OnClick;
	void Start() {
		accuracy.gameObject.SetActive(false);
		OnClick += SetAccuracy;
		AroundArrowsTriggers.OnNoClick += SetAccuracy;
	}
	void Update () {
		if(Input.anyKeyDown){
			if(!Input.GetButton(dir.ToString()))
				accuracy.text = "Miss";
			if(OnClick != null)
				OnClick();
		}
	}
	void SetAccuracy () {
		accuracy.gameObject.SetActive(true);
	}
}
