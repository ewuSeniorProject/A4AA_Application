using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionF
{
    class Alt_inf_typ : Question
    {
		public Alt_inf_typ()
		{
			TheAnswer = new A_Text(4);
			QuestionText = "Choose the type of format";
			HasOptions = true;

			options = new String[]
			{
				"Braille",
				"Large print",
				"Recorded audio",
				"Video"
			};
		}
	}
}
