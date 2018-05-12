using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ
{
    class Sta_dis_tra_desc : Question
    {
		public Sta_dis_tra_desc()
		{
			TheAnswer = new A_Text(255);
			QuestionText = "Describe the type of training, how it was delivered, and how often it is provided";
		}
    }
}
