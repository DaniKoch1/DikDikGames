using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public static IEnumerator Fade(GameObject arrow){
		Renderer render = arrow.GetComponent<SpriteRenderer>();
		Color c = render.material.color;
		for(float f = 1; f >= -0.05f; f -= 0.05f){
			//c = render.material.color;
			c.a = f;
			render.material.color = c;
			yield return new WaitForSeconds(0.0001f);
		}
		c.a=1;
		render.material.color = c;
		arrow.SetActive(false);
	}
}
