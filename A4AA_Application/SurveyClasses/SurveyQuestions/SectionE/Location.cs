using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionE
{
    class Location : Question
    {
		public Location()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "If ‘yes,’ WHERE is nearest elevator or lift located in relation to the accessible entrance? Explain: ";
		}
    }
}
