using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionB
{
    class STA_Bus_Rou_Num : Question
    {
		public STA_Bus_Rou_Num()
		{
			TheAnswer = new A_Int11();
			QuestionText = "How many Routes are available?";
		}
    }
}
