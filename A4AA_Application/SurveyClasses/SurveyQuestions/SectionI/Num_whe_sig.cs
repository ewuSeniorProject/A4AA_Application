using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI
{
    class Num_whe_sig : Question
    {
		public Num_whe_sig()
		{
			TheAnswer = new A_Int11();
			QuestionText = "Number of restrooms that have “WHEELCHAIR ACCESSIBLE” signs";
		}
    }
}
