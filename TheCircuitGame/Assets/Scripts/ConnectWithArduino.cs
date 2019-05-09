using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ConnectWithArduino : MonoBehaviour {

	// SerialPort sp = new SerialPort("COM8", 9600); // set port of your arduino connected to computer
	// public static GameObject activeArrow;
	// private ArrowDirection button;
	// public static event AroundArrowsTriggers.ClickAction OnClick;

	// void Start () {
	// 	sp.Open();
	// 	sp.ReadTimeout = 1;
	// }

	// void Update () {
	// 	if (sp.IsOpen) {
	// 		try {
	// 			var readValue = sp.ReadByte();
	// 			if (readValue == 1) {
	// 				//button = ArrowDirection.Right;
	// 				//Debug.Log("Right");
	// 				CheckInput(ArrowDirection.Right);
	// 			}
	// 			if (readValue == 2) {
	// 				//button = ArrowDirection.Up;
	// 				//Debug.Log("Up");
	// 				CheckInput(ArrowDirection.Up);
	// 			}
	// 			if (readValue == 3) {
	// 				//button = ArrowDirection.Down;
	// 				//Debug.Log("Down");
	// 				CheckInput(ArrowDirection.Down);
	// 			}
	// 			if (readValue == 4) {
	// 				//button = ArrowDirection.Left;
	// 				//Debug.Log("Left");
	// 				CheckInput(ArrowDirection.Left);
	// 			}
				
	// 		} catch (System.Exception) {
	// 		}
	// }
	// }
	// private void CheckInput(ArrowDirection dir){
	// 	if(dir != activeArrow.GetComponent<ArrowDirection>()){
	// 		Debug.Log("The buttons don't match");
	// 		TextSingleton.Instance.accuracyText = "Miss";
	// 		ScoreManager.Instance.score = 0;
	// 	}
	// 	Debug.Log("OnClick will happen now");
	// 	OnClick();
	// }
}
