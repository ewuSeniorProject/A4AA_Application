using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Ram_Lev_Lan_Loc : Question
    {
        //private string[] options;

        public Ext_Ram_Lev_Lan_Loc()
        {
            TheAnswer = new A_Text(32);
            QuestionText = "Is there a level landing that is at least 60 inches long and at least as wide as the ramp at the top or bottom of the ramp?";
            HasOptions = true;

            options = new string[] 
            {
                "Top",
                "Bottom",
                "N/A"
            };
        }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
