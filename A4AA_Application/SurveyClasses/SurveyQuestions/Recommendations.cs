using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    class Recommendations : Question
    {
		public Recommendations()
		{
			TheAnswer = new A_Text(5000);
			QuestionText = "Comments: ";
		}
    }
}
