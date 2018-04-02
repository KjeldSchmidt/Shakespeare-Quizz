using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question {

	private String question {get;}
	private String answer1 {get;}
	private String answer2 {get;}
	private String answer3 {get;}
	private String answer4 {get;}
	private int correctAnswer;

	public Question( String question, String answer1, String answer2, String answer3, String answer4, int correctAnswer ) {
		this.question = question;
		this.answer1 = answer1;
		this.answer2 = answer2;
		this.answer3 = answer3;
		this.answer4 = answer4;
		this.correctAnswer = correctAnswer;
	}

	public Question( String csvString ) {
		String[] inputs = csvString.Split(';');
		Debug.Assert( inputs.Length == 6, "Question cvs string is invalid, incorrect number of arguments.");
		int correct = -1;
		Int32.TryParse(inputs[5], out correct);
		Debug.Assert( correct > 0 && correct < 5, "Question cvs string is invalid, correct answer not given as valid int.");
		this.question = inputs[0];
		this.answer1 = inputs[1];
		this.answer2 = inputs[2];
		this.answer3 = inputs[3];
		this.answer4 = inputs[4];
		this.correctAnswer = correct;
	}

	public bool checkAnswer(int answer) {
		return answer == correctAnswer;
	}
}
