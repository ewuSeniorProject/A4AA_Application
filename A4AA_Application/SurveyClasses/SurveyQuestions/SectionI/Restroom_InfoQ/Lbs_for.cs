using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ
{
    class Lbs_for : Question
    {
		public Lbs_for()
		{
			TheAnswer = new A_Int11();
			QuestionText = "How many lbs of force?";
		}
    }
}
