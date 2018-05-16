using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Ass_lis_rec : Question
    {
		public Ass_lis_rec()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Reciever Type:";
			HasOptions = true;

			options = new string[]
			{
				"Earbud",
				"Neckloop",
				"Headphones",
				"other (Specify in comments)"
			};
		}
    }
}
