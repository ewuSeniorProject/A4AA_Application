using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Sco_loc : Question
    {
		public Sco_loc()
		{
			QuestionText = "Where are they located and accessed?";
			TheAnswer = new A_Text(255);
		}
    }
}
