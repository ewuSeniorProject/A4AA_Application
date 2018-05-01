﻿using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
	public abstract class YesNoQuestion: Question
    {
		private string[] options;

		public YesNoQuestion(String question)
		{
			TheAnswer = new A_Text(4);
			QuestionText = question;

			options = new String[]
			{
				"Yes",
				"No",
                "N/A"
			};
		}

		public string[] Options { get => options; set => options = value; }
	}
}
