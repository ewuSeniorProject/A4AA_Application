using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionD
{
    class Int_doo_ope_for : Question
    {
		public Int_doo_ope_for()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "How many lbs of force is required?";
		}
    }
}
