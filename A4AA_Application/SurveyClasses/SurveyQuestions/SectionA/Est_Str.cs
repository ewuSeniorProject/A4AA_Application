using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Est_Str : Question
    {
        public Est_Str()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "Street address, including suite or lot number:";
            ErrorMessage = "Invalid data. 255 characters allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
