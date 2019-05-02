using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public static IEnumerator Fade(SpriteRenderer render){
		Debug.Log("Fading");
		for(float f = 1; f >= -0.05f; f -= 0.1f){
			Color c = render.material.color;
			c.a = f;
			render.material.color = c;
			yield return new WaitForSeconds(0.0001f);
		}
	}
}
