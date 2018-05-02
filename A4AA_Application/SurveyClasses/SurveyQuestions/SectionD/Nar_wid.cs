using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionD
{
	class Nar_wid : Question
	{
		public Nar_wid()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "What is the measurement of the narrowest part of the door?";
		}
	}
}
