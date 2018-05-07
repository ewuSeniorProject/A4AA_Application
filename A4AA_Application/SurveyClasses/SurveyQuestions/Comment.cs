using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Comment : Question
    {
		public Comment(String additional_words)
		{
			TheAnswer = new A_Text(5000);
			QuestionText = "Comments: " + additional_words;

		}

		public Comment()
		{
			TheAnswer = new A_Text(5000);
			QuestionText = "Comments: ";

		}
    }
}
