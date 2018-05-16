using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionG
{
    class Eva_inf_for : Question
    {
		public Eva_inf_for()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Format Type:";
			HasOptions = true;

			options = new string[]
			{
				"Braille",
				"Large Print",
				"Recorded Audio",
				"Video",
				"Other (please specify in comments)"
			};
		}
}
}
