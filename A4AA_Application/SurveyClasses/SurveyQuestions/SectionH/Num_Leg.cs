using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionH
{
    class Num_Leg : Question
    {
		public Num_Leg()
		{
			TheAnswer = new A_Text(4);
			QuestionText = "Enter the number of tables that have leg room or enter \"all\"";
		}
    }
}
