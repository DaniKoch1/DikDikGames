using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public static IEnumerator Fade(GameObject arrow, float time){
		Renderer render;
		if( arrow.GetComponent<SpriteRenderer>() != null) //totally against open closed principle!
			render = arrow.GetComponent<SpriteRenderer>();
		else
			render = arrow.GetComponent<MeshRenderer>();
		Color c = render.material.color;
		for(float f = 1; f >= -0.05f; f -= 0.05f){
			//c = render.material.color;
			c.a = f;
			render.material.color = c;
			yield return new WaitForSeconds(time);
		}
		c.a=1;
		render.material.color = c;
		arrow.SetActive(false);
		TextSingleton.Instance.accuracyText="Miss";
		ScoreManager.Instance.score=0;
	}
}
