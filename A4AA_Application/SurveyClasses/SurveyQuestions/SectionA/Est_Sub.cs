﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Est_Sub : Question
    {
        public Est_Sub()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "Subtype (EX: Fast Food, Motel, Movie Theater, Apparel, etc.):";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
