using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionH
{
    class Num_tab_rea : Question
    {
		public Num_tab_rea()
		{
			TheAnswer = new A_Text(4);
			QuestionText = "Enter the number of tables that can be rearranged or enter \"all\"";
		}
    }
}
