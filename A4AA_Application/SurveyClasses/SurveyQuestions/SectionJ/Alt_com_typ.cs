using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Alt_com_typ: Question
    {
		public Alt_com_typ() {
			QuestionText = "If ‘yes’, what ­­ writing pad, staff know ASL, etc";
			TheAnswer = new A_Text(255);
		}
    }
}
