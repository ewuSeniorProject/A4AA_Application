using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Mai_Ent_Doo_Act : Question
    {
        //private string[] options;

        public Mai_Ent_Doo_Act()
        {
            TheAnswer = new A_Text(24);
            QuestionText = "How does the door open?";
            HasOptions = true;

            options = new string[] 
            {
                "Slide to the side",
                "Open out",
                "Open in",
                "Other"
            };
        }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
