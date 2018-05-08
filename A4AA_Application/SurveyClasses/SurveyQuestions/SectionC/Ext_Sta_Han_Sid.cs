using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Sta_Han_Sid : Question
    {
        //private string[] options;

        public Ext_Sta_Han_Sid()
        {
            TheAnswer = new A_Text(24);
            QuestionText = "Where are the handrails located?";
            HasOptions = true;

            options = new string[] 
            {
                "Left Side",
                "Right Side",
                "Neither Side"
            };
        }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
