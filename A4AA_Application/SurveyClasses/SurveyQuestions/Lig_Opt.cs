using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Lig_Opt : Question
    {
		

		public Lig_Opt()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Lighting Option:";
			HasOptions = true;

			options = new string[]
			{
				"Day",
                "Night"
			};
		}
	}
}
