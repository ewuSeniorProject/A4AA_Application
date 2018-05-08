using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Pat_Ser_Ani_Loc : Question
    {
        public Ext_Pat_Ser_Ani_Loc()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "If there is a service animal relief area, where is it located?";
            ErrorMessage = "Invalid data. 255 characters allowed.";
        }
    }
}
