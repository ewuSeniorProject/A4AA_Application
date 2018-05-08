using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Pas_Loa_Dis : Question
    {
        public Pas_Loa_Dis()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Distance from passenger loading zone to wheelchair accessible entrance:";
            ErrorMessage = "Invalid data. Up to 5 characters left of decimal and up to 2 characters right of decimal allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
