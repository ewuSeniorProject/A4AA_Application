using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionE
{
    class Outside_btn_height : Question
    {
		public Outside_btn_height()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "What is the height of the buttons on the outside of the elevator in inches? ";
		}
    }
}
