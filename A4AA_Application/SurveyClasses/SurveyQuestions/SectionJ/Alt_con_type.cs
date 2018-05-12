using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Alt_con_type : Question
    {
		public Alt_con_type()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Alternate Type:";
			HasOptions = true;

			options = new string[]
			{
				"Text",
				"On-line",
				"Phone",
				"Other (Specify in comments)"
			};
		}
	}
}
