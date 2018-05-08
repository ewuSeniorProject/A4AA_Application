using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class STA_Rou_Rou_Num : Question
    {
        public STA_Rou_Rou_Num()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Route number:";
            ErrorMessage = "Invalid data. 11 characters allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
