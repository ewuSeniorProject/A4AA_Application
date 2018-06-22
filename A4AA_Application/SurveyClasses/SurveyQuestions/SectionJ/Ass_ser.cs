using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Ass_ser : Question
    {
		public Ass_ser()
		{
			TheAnswer = new SurveyAnswers.A_Text(255);
			QuestionText = "Service Available:";
			HasOptions = true;

			options = new string[]
			{
				"Assistance",
				"Delivery",
				"Other (Specify in comments)"
			};
		}
}
}
