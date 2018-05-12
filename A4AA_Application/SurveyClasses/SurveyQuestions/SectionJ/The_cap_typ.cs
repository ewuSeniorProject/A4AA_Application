using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class The_cap_typ : Question
    {
		public The_cap_typ()
		{
			QuestionText = "If ‘yes’, what type of captioning is used?";
			TheAnswer = new A_Text(255);

			HasOptions = true;

			options = new string[]
			{
				"Real time",
				"Open captions",
				"Rear window",
				"other (Specify in comments)",
				"N/A"
			};
		}
	}
}
