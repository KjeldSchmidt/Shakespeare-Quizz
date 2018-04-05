using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class QuestionManager {

	private static bool isInitialized = false;
	public static string questionsPath = "/Questions.txt";
	private static Queue<Question> questions = new Queue<Question>();

	public static void init() {
		if ( !isInitialized ) {
			if ( !BetterStreamingAssets.FileExists(questionsPath) ) {
				Debug.Log("Could not find questions file!");
				throw new FileNotFoundException("Could not find questions file!");
			}
			string[] questionsFile = BetterStreamingAssets.ReadAllLines(questionsPath);
			string[] csvQuestions = String.Join(";", questionsFile).Split('#');
			List<Question> questionList = new List<Question>();
			foreach ( string questionString in csvQuestions ) {
				questionList.Add( new Question(questionString) );
			}
			questionList.Shuffle();
			questions = new Queue<Question>(questionList);
			isInitialized = true;
		}
	}

	public static Question getNextQuestion() {
		return questions.Dequeue();
	}
}
