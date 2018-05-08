using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Est_Con_Fna : Question
    {
        public Est_Con_Fna()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "Contact First Name:";
            ErrorMessage = "Invalid data. 255 characters allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
