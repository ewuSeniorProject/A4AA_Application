using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Ass_lis_typ : Question
    {
		public Ass_lis_typ()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Listening Type:";
			HasOptions = true;

			options = new string[]
			{
				"Infra­red loop",
				"induction",
				"loop",
				"FM",
				"amplification",
				"other (Specify in comments)"
			};
		}
    }
}
