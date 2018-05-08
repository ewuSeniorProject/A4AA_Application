﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Rou_Fro_Par_Dis : Question
    {
        public Rou_Fro_Par_Dis()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "What is the distance from reserved parking to a wheelchair accessible entrance?";
            ErrorMessage = "Invalid data. Up to 5 characters left of decimal and up to 2 characters right of decimal allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
