﻿using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Lig_Typ : Question
    {
		

		public Lig_Typ()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Lighting Type:";
			HasOptions = true;

			options = new string[]
			{
				"Low",
				"Medium",
				"Bright"
			};
		}
	}
}
