using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionH
{
    class Num_cha_rea : Question
    {
		public Num_cha_rea()
		{
			TheAnswer = new A_Text(4);
			QuestionText = "Enter the number of chairs that can be rearranged or enter \"all\"";
		}
	}
}
