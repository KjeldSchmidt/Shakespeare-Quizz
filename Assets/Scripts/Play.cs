using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour {
	public Texture background;
	public Text questionBoard;

	void Start() {
		QuestionManager.init();
		Question question = QuestionManager.getNextQuestion();
		questionBoard.text = question.getQuestion();

	}
}
