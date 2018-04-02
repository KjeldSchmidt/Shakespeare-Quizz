using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Animator>()["Vorhang 0"].wrapMode = WrapMode.Once;
		GetComponent<Animator>().Play("Vorhang 0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
