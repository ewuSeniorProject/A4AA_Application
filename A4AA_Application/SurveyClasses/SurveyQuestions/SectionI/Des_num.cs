using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI
{
    class Des_num : Question
    {
		public Des_num()
		{
			TheAnswer = new A_Int11();
			QuestionText = "Number of accessible restrooms DESIGNATED “family”, “unisex”, or “assisted use”";
		}
    }
}
