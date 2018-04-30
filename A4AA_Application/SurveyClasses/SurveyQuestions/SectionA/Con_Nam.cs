using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Con_Nam : Question
    {
        private string[] options;

        public Con_Nam()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "Premises Configuration:";
            options = new string[]
            {
                "Stand Alone",
                "Inside Mall",
                "Strip Mall",
                "Office Building",
                "Skywalk",
                "Other (explain in comments)"
            };
        }

        public string[] Options { get => options; set => options = value; }

        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
