using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {
	public Texture background;
	public HashSet<Question> questions;

	void Start() {
		QuestionManager.init();
	}
}
