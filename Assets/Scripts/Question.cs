using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question {

	private String question;
	private String answer1;
	private String answer2;
	private String answer3;
	private String answer4;

	public Question( String question, String answer1, String answer2, String answer3, String answer4, int correctAnswer ) {
		this.question = question;
		this.answer1 = answer1;
		this.answer2 = answer2;
		this.answer3 = answer3;
		this.answer4 = answer4;
	}

	public Question( String csvString ) {
		char[] splitters = { ';' };
		String[] inputs = csvString.Split(splitters, System.StringSplitOptions.RemoveEmptyEntries);
		Debug.Assert( inputs.Length == 5, "Question cvs string is invalid, incorrect number of arguments.");
		this.question = inputs[0];
		this.answer1 = inputs[1];
		this.answer2 = inputs[2];
		this.answer3 = inputs[3];
		this.answer4 = inputs[4];
	}

	public bool checkAnswer(int answer) {
		return answer == 1;
	}

	public string getQuestion() {
		return this.question;
	}
	public string getAnswer1() {
		return this.answer1;
	}
	public string getAnswer2() {
		return this.answer2;
	}
	public string getAnswer3() {
		return this.answer3;
	}
	public string getAnswer4() {
		return this.answer4;
	}
}
