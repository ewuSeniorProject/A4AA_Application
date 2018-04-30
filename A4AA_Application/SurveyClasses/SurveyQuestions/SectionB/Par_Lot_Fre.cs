using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Lot_Fre : Question
    {
        private string[] options;

        public Par_Lot_Fre()
        {
            TheAnswer = new A_Text(24);
            QuestionText = "Parking Cost:";

            options = new string[] 
            {
                "Free",
                "Paid"
            };
        }

        public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
