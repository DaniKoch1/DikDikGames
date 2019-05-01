using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {
	public GameObject particle;
	 void Start() {
		EventManager.OnClick += DisapearArrowWithParticle;
	}
	public void DisapearArrowWithParticle(){
		Instantiate(particle, gameObject.transform);
	}
}
