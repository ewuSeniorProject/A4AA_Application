using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI
{
    class Tot_num : Question
    {
		public Tot_num()
		{
			TheAnswer = new A_Int11();
			QuestionText = "Total NUMBER of public restrooms";
		}
    }
}
