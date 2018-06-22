using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionH
{
    class Num_des_spa : Question
    {
		public Num_des_spa()
		{
			TheAnswer = new A_Int11();
			QuestionText = "Enter the number of designated spaces";
		}
    }
}
