using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionD
{
    class Lig_Typ : Question
    {
		private string[] options;

		public Lig_Typ()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Category of Establishment:";

			options = new string[]
			{
				"Low",
				"Medium",
				"Bright"
			};
		}
		public string[] Options { get => options; set => options = value; }
	}
}
