﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class STA_Bus_Lig_Opt : Question
    {
        private string[] options;

        public STA_Bus_Lig_Opt()
        {
            TheAnswer = new A_Text(32);
            QuestionText = "Day or night?";

            options = new string[] 
            {
                "Day",
                "Night"
            };
        }

        public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}