﻿using A4AA_Application.SurveyClasses.SurveyAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionF
{
    class Sig_hei : Question
    {
		public Sig_hei()
		{
			TheAnswer = new A_Decimal5_2();
			QuestionText = "What is the signs' height?";
		}
    }
}
