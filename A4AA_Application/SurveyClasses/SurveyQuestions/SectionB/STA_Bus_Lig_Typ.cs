using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class STA_Bus_Lig_Typ : Question
    {
        //private string[] options;

        public STA_Bus_Lig_Typ()
        {
            TheAnswer = new A_Text(32);
            QuestionText = "Brightness level:";
            HasOptions = true;

            options = new string[] 
            {
                "Low",
                "Medium",
                "Bright"
            };
        }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
