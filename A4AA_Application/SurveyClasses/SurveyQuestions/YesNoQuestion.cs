using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
	public abstract class YesNoQuestion: Question
    {
		

		public YesNoQuestion(String question)
		{
			TheAnswer = new A_Text(4);
			QuestionText = question;
			HasOptions = true;
			TheAnswer.setAnswer("N/A");

			options = new String[]
			{
				"Yes",
				"No",
                "N/A"
			};
		}

		
	}
}
