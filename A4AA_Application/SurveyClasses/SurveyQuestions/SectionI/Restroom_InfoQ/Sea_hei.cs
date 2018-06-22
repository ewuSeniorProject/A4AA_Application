using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ
{
    class Sea_hei : Question
    {
		public Sea_hei()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "Toilet Seat Height";
		}
    }
}
