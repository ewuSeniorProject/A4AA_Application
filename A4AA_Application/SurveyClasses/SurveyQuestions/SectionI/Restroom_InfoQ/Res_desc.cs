using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ
{
    class Res_desc : Question
    {
		public Res_desc()
		{
			TheAnswer = new A_Text(5000);
			QuestionText = "Please clearly identify each bathroom rated with location and other information(i.e.1st floor front women’s).";
		}
    }
}
