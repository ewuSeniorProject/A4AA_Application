using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ
{
    class Tur_wid : Question
    {
		public Tur_wid()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "Width";
		}
    }
}
