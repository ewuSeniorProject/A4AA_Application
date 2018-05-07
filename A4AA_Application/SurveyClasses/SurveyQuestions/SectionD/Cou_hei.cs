using A4AA_Application.SurveyClasses.SurveyAnswers;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Cou_hei: Question
    {
		public Cou_hei()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "What is the counter height?";
		}
    }
}
