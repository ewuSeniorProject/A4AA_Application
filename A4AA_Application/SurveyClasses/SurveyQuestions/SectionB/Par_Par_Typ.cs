using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Par_Typ : Question
    {
        //private string[] options;

        public Par_Par_Typ()
        {
            TheAnswer = new A_Text(24);
            QuestionText = "Parking Type:";
            HasOptions = true;

            options = new string[] 
            {
                "Garage",
                "Valet",
                "Other"
            };
        }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
