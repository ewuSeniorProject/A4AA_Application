using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ
{
    class Bar_hei : Question
    {
		public Bar_hei()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "Bar Height";
		}
    }
}
