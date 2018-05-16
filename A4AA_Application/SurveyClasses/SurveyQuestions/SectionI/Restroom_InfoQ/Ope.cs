using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ
{
	class Ope : Question
	{
		public Ope()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "Measurement of opening";
		}
	}
}
