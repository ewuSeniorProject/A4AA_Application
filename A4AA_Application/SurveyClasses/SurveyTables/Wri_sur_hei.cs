using A4AA_Application.SurveyClasses.SurveyAnswers;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Wri_sur_hei : Question
    {
		public Wri_sur_hei()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "What is the writing surface height?";
		}
	}
}
