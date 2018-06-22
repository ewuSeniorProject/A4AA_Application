using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Aco_lev: Question
    {
		public Aco_lev()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Noise Level:";
			HasOptions = true;

			options = new string[]
			{
				"Low",
				"Medium",
				"High"
			};
		}
}
}
