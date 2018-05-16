using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Sen_age : Question
    {
		public Sen_age()
		{
			TheAnswer = new A_Int11();
			QuestionText = "What age is considered 'Senior'?";
		}
    }
}
